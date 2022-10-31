using AtBash_Cypher.Encrypter;

Encryption v = new Encryption();
Console.WriteLine("Enter a word to Encrypt");

string wordToEncrypt = Console.ReadLine()!;

Console.WriteLine($"Encrypted Word  = {v.Encrypt(wordToEncrypt)}");

Console.WriteLine("Enter a word to decrypt");
string wordToDecrypt = Console.ReadLine()!;
Console.WriteLine($"Decrypted Word  = {v.Decrypt(wordToDecrypt)}");
