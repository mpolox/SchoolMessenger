variable "SCM_ASP" {
  type = string
  # default = "SchoolMessengerASP"
  description = "Value for the ASP name for the application"  
}

variable "SCM_RSG" {
  type = string
  # default = "SchoolMessengerRSG"
  description = "Value for the RSG name for the application"  
}

variable "SCM_API" {
  type = string
  # default = "SchoolMessengerAPI"
  description = "Value for the API Name for the application"  
}

variable "SCM_Location" {
  type = string
  default = "East US 2"
  description = "Location for SCM app"  
}

variable "SCM_NetVersion" {
  type = string
}

variable "Dev_Tags" {
  type = object({
    Project = string
    Environment = string
  })


  
}
