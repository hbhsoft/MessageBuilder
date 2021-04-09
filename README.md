# MessageBuilder
MyMessageBuilder API
This API support to encrypt and decrypt string, the encrypt string is display as hex string
The API library is protected so the reverse engineering will take time to find how the string encrypt
This API only support x64 application

Usage
Add reference to library "MyMessageBuilder.dll"
Copy dependency dll to same folder: myEasyDotnetLoader.dll,myDotnetLoader.dll,cryptopp_net.dll

//To encrypt
string result = MyMessageBuilderAPI.Encrypt("Hello MyMessageBuilderAPI");

//To decrypt
string result1 = MyMessageBuilderAPI.Decrypt(result);

Note:
The api only support UTF8 string, for unicode please convert to base64 first.
The api use popular cryptopp library for encrypt and decrypt data instead using framework library
https://github.com/weidai11/cryptopp
