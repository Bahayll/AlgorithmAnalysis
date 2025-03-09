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
1. adım: **7,12**,9,11,3        + 8. adım: '7,9',11,3,12        12. adım:'7,9',3,11,12          15. adım: '7,3',9,11,12
2. adım:  7,'12,9',11,3       9. adım:  7,'9,11',3,12       13. adım: 7,'9,3',11,12         16. adım: '3,7',9,11,12
3. adım:  7,'9,12',11,3       10. adım: 7,9,'11,3',12       14. adım: 7,'3,9',11,12
4. adım:  7,9,'12,11',3       11. adım: 7,9,'3,11',12
5. adım:  7,9,'11,12',3       
6. adım:  7,9,11,'12,3'
7. adım:  7,9,11,'3,12'



