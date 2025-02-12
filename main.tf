resource "null-resource" "test" {
    count = 2
    provisioner "local-exec" {
        command = "echo ${count.index}"
    }
}