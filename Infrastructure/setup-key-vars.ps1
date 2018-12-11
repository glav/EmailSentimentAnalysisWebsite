$clientid="6349a021-c1fc-44da-a0dd-9651b8aa9f33"
$clientPwd="471221ea-a442-44f2-ac7b-602f9bf55d75"
$tenantid="25551a9f-8b28-4638-bb80-5be15cece26f"
$subid="d6876356-8975-4384-bbec-4be79f7fe030"

set-item env:ARM_SUBSCRIPTION_ID $subid
set-item env:ARM_CLIENT_ID $clientId
set-item env:ARM_CLIENT_SECRET $clientPwd
set-item env:ARM_TENANT_ID $tenantid
set-item env:ARM_ENVIRONMENT "public"

 