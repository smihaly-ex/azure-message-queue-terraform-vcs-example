# This is a simple example of how to use the count meta-argument to create multiple instances of a resource.
resource "null_resource" "test" {
    count = 2
    provisioner "local-exec" {
        command = "echo ${count.index}"
    }
}