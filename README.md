# AlgorithmAnalysis
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



