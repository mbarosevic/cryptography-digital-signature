# Encryption, Decryption and Digital Signature check Application
### Cryptography
Cryptography is technique of securing information and communications through use of codes so that only those person for whom the information is intended can understand it and process it. Thus preventing unauthorized access to information. The prefix “crypt” means “hidden” and suffix graphy means “writing”.

### Symmetric Cryptography
For symmetric key cryptography is used Advanced Encryption Standard (AES) algorithm.
AES is a cryptographic algorithm used to protect electronic data. It’s a symmetric block cipher that can encrypt and decrypt information. Encryption converts data to an unintelligible form called ciphertext. Decryption converts the data back into its original form called plaintext. The encryption key length of 256 bits is being used, which can encrypt and decrypt data in blocks of 128 bits.
![alt text](https://www.ssl2buy.com/wiki/wp-content/uploads/2015/12/Symmetric-Encryption.png)

### Asymmetric Cryptography
Asymmetric Cryptography, also known as public key cryptography, uses public and private keys to encrypt and decrypt data. The keys are simply large numbers that have been paired together but are not identical (asymmetric). One key in the pair can be shared with everyone; it is called the public key. The other key in the pair is kept secret; it is called the private key. Either of the keys can be used to encrypt a message; the opposite key from the one used to encrypt the message is used for decryption. To achieve public key cryptography, for this project is used RSA (Rivest-Shamir-Adleman) which is the most widely used asymmetric algorithm. RSA derives its security from the computational difficulty of factoring large integers that are the product of two large prime numbers. Multiplying two large primes is easy, but the difficulty of determining the original numbers from the product -- factoring -- forms the basis of public key cryptography security. The time it takes to factor the product of two sufficiently large primes is considered to be beyond the capabilities of most attackers, excluding nation-state actors who may have access to sufficient computing power. RSA keys are typically 1024- or 2048-bits long, but experts believe that 1024-bit keys could be broken in the near future, which is why government and industry are moving to a minimum key length of 2048-bits.
![alt text](https://www.ssl2buy.com/wiki/wp-content/uploads/2015/12/Asymmetric-Encryption.png)

### Digital signature
Digital signature is a mathematical technique used to validate the authenticity and integrity of a message, software or digital document. As the digital equivalent of a handwritten signature or stamped seal, a digital signature offers far more inherent security, and it is intended to solve the problem of tampering and impersonation in digital communications. Digital signatures are based on public key cryptography, also known as asymmetric cryptography. Using a public key algorithm, such as RSA, one can generate two keys that are mathematically linked: one private and one public.
![alt text](https://www.tutorialspoint.com/cryptography/images/model_digital_signature.jpg)

