terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
      version = "2.99.0"
    }
  }
}

provider "azurerm" {
   features {}
}

#RSG
resource "azurerm_resource_group" "SCM" {
  name      = var.SCM_RSG
  location  = var.SCM_Location
  tags      = var.Dev_Tags 
}

#ASP
resource "azurerm_app_service_plan" "SCM" {
  name                = var.SCM_ASP
  location            = azurerm_resource_group.SCM.location
  resource_group_name = azurerm_resource_group.SCM.name
  sku {
    tier = "Free"
    size = "F1"
  }
  tags = var.Dev_Tags
}

#APP
resource "azurerm_app_service" "SCM" {
  name                = var.SCM_API
  location            = azurerm_resource_group.SCM.location
  resource_group_name = azurerm_resource_group.SCM.name
  app_service_plan_id = azurerm_app_service_plan.SCM.id

  site_config {
    use_32_bit_worker_process = true
    dotnet_framework_version  = "v6.0"
   scm_type                   = "LocalGit"    
  }

  app_settings = {
    "SOME_KEY" = "some-value"
  }

  connection_string {
    name  = "Database"
    type  = "SQLServer"
    value = "Server=some-server.mydomain.com;Integrated Security=SSPI"
  }
}