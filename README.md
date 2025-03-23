# Algorithm Analysis
## Lecture Notes
![1](https://github.com/user-attachments/assets/0da3b0af-4ca4-4b20-b2af-85520baae1a0)
![2](https://github.com/user-attachments/assets/82f24212-dc53-4553-9b5e-8fbf35744197)
![3](https://github.com/user-attachments/assets/963e9847-aff6-4a95-9c72-2adcf4722f54)
![4](https://github.com/user-attachments/assets/08ba217d-ca30-4864-afc9-cbedda89aa81)
![5](https://github.com/user-attachments/assets/df19094c-7c54-4552-a162-2afec0d84645)
![6](https://github.com/user-attachments/assets/fdabf71b-e54c-4c63-b0b8-04a0e57f5b4f)
![7](https://github.com/user-attachments/assets/810f55c9-25d9-46ab-9cc8-80a0d6e16794)
![8](https://github.com/user-attachments/assets/b13661e6-3377-471c-bf52-fa28de5391ef)
![9](https://github.com/user-attachments/assets/08e0f04b-68f2-49c8-8c68-83531100d8f0)
![10](https://github.com/user-attachments/assets/2cfd17db-2578-4ef3-87af-8d2ca3c17af5)
![11](https://github.com/user-attachments/assets/f405c25b-8edc-437d-bbb5-2572d7e6a2b9)
![12](https://github.com/user-attachments/assets/63b312e4-b31c-4141-b49c-5b058bd9b7f5)
![13](https://github.com/user-attachments/assets/e0860d8c-f145-46f6-966d-3bd47816d7c9)
![14](https://github.com/user-attachments/assets/b69a534d-da7d-4de2-97f6-e5b06d573e22)
![15](https://github.com/user-attachments/assets/ee721bb3-3272-4903-8236-68f327cda039)
![16](https://github.com/user-attachments/assets/8e0e4c15-02fb-4293-b75b-a3217463738a)
![17](https://github.com/user-attachments/assets/77cf8083-a66f-4378-beb4-a2f4fb90ebdd)
![18](https://github.com/user-attachments/assets/c3268177-8267-4f36-a31a-592381b72fd8)
![19](https://github.com/user-attachments/assets/1282f747-3136-430d-b5e4-41e624f929f8)
![20](https://github.com/user-attachments/assets/dcd2f9a8-b37d-47eb-9b18-af9120556c35)
![21](https://github.com/user-attachments/assets/fead9a12-f095-4294-9f5b-ba5530961c74)
![22](https://github.com/user-attachments/assets/cfc1da9a-db32-4ec2-a919-6327555389a0)
![23](https://github.com/user-attachments/assets/21d912d3-c010-402f-9511-29634d688929)
![24](https://github.com/user-attachments/assets/8a550cbd-12e6-4e7d-9d42-8b4ddc648a92)
![25](https://github.com/user-attachments/assets/0cdf23b8-ff72-4f17-a104-1816c59650d7)
![26](https://github.com/user-attachments/assets/84a21f72-cced-4530-95d5-6d83a663f726)

## 1. Bubble Sort 
### Bubble Sort Nedir?
+ Bubble Sort, en basit sıralama algoritmalarından biridir.
+ Algoritma, diziyi tekrar tekrar dolaşarak yan yana bulunan iki elemanı karşılaştırır ve sıralama kriterine göre yer değiştirir. Bu işlem, dizinin tamamen sıralanmış hale gelene kadar devam eder.
### Bubble Sort Algoritması Çeşitleri
+ Standart Bubble Sort → Her elemanı bir sonrakiyle karşılaştırarak sıralar.
+ Optimize Edilmiş Bubble Sort → Eğer bir turda hiçbir değişiklik yapılmazsa, dizinin zaten sıralandığını anlar ve işlemi erken durdurur. 
### Bubble Sort'un Avantajları:
+ Kabarcık sıralaması anlaşılması ve uygulanması kolay bir yöntemdir.
+ Herhangi bir ek bellek alanına ihtiyaç duymaz.
+ Bu, aynı anahtar değerine sahip elemanların sıralanmış çıktıda göreceli sıralarını koruduğu anlamına gelen kararlı bir sıralama algoritmasıdır.
### Bubble Sort'un Dezavantajları:
+ Kabarcık sıralaması , büyük veri kümeleri için çok yavaş olmasına neden olan O(n 2 ) zaman karmaşıklığına sahiptir .
+ Kabarcık sıralaması gerçek dünyada neredeyse hiç veya sınırlı uygulamaya sahip değildir. Çoğunlukla akademik alanda farklı sıralama yöntemlerini öğretmek için kullanılır.
### Nasıl çalışır:
1. Diziyi, her seferinde bir değer olacak şekilde inceleyin.
2. Her değer için değeri bir sonraki değerle karşılaştırın.
3. Eğer değer bir sonrakinden büyükse, en yüksek değer en sona gelecek şekilde değerleri değiştirin.
4. Dizideki değer sayısı kadar diziyi tekrar tekrar gözden geçirin.

### ÖRNEK
7,12,9,11,3 bubble sort algoritmasını adım adım uygulayalım.
#### 1. iterasyon 
1. adım: <ins>7,12</ins>,9,11,3                   
2. adım:  7,<ins>12,9</ins>,11,3                    
3. adım:  7,<ins>9,12</ins>,11,3            
4. adım:  7,9,<ins>12,11</ins>,3      
5. adım:  7,9,<ins>11,12</ins>,3       
6. adım:  7,9,11,<ins>12,3</ins>
7. adım:  7,9,11,<ins>3,12</ins>
#### 2. iterasyon 
8. adım: <ins>7,9</ins>,11,3,12
9. adım:  7,<ins>9,11</ins>,3,12
10. adım: 7,9,<ins>11,3</ins>,12
11. adım: 7,9,<ins>3,11</ins>,12
#### 3. iterasyon 
12. adım: <ins>7,9</ins>,3,11,12
13. adım: 7,<ins>9,3</ins>,11,12
14. adım: 7,<ins>3,9</ins>,11,12
#### 4. iterasyon 
15. adım: <ins>7,3</ins>,9,11,12
16. adım: <ins>3,7</ins>,9,11,12

![image](https://github.com/user-attachments/assets/967ff612-6ccd-43e1-80f6-77581f11fbf0) ![image](https://github.com/user-attachments/assets/d2eeb083-7455-458e-8189-235bd078ac9a)



