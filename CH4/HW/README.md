# 解答

因為任何天氣都有不同的溼度和溫度，但是都必須去計算出尾巴會是什麼顏色。當多出一種氣候，就要到 `Color` 做新增，違反了封閉原則。這邊可以將這個共同要去計算顏色的部分拿到 abstract class ，並且讓所有不同的天氣去繼承。如此一來，當一有新的氣候時，只要新增新的天氣 class，就可以不去動到原本的 `Color` class 了。

![](https://i.imgur.com/DJIXjjr.png)