# Login to the Big Cloud Fabric
You can use the below script to perfom a login function to the BCF controller.

This script uses the funcitons `login_bcf_controller.py` and `get_sessioncookie.py` to login to the controller.

### Login Example
```python
login_bcf_controller.py
```

```shell
param(
    # The Protection Job Id
    [Parameter(Mandatory=$true, Position=0)]
    [long]
    $JobId,

    # Mode: Append or Replace
    [Parameter(Mandatory=$true, Position=1)]
    [ValidateNotNullOrEmpty()]
    [ValidateSet("Append", "Replace")]
    [string]
    $Mode,

    # VMs to be added to the Protection Job
    [Parameter(Mandatory=$true, Position=2)]
    [ValidateNotNullOrEmpty()]
    [string[]]
    $VmNames
)


```
