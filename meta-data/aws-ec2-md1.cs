// to retrieve the current EC2 instance’s Id and network interfaces:
string instanceId = EC2Metadata.InstanceId;
Console.WriteLine("Current instance: {0}", instanceId);

var networkInstances = EC2Metadata.NetworkInterfaces;
foreach(var netInst in networkInstances)
{
    Console.WriteLine("Network Interface: Owner = {0}, MacAddress = {1}", netInst.OwnerId, netInst.MacAddress);
}

//To retrieve the current instance Id
string instanceId = EC2Metadata.GetData("/instance-id");
Console.WriteLine("Current instance: {0}", instanceId);

// Retrieve nodes from the root, http://169.254.169.254/latest/meta-data/
var rootNodes = EC2Metadata.GetItems(string.Empty);
foreach(var item in rootNodes)
{
    Console.WriteLine(item);
}