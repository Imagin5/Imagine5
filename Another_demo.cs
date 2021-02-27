public int MyProperty { get; set; }

private void OnFailedToConnect(NetworkConnectionError error) {
    MyProperty = 10;




public int Another { get; set; }

private void OnFailedToConnect(NetworkConnectionError error) {
    MyProperty = 10;
}