variable "environment" {
  default="dev"
}
variable "location" {
  default = "australiaeast"
}

variable "app_insights_location" {
  default = "southeastasia"
}

variable "app" {
  default = "EmailSentiment"
}


locals {
  queue_name = "${var.app}${var.environment}"
  resource_group_name = "${var.app}${var.environment}"
}