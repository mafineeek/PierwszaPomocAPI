# PierwszaPomocAPI

# /Questions/all
## Example response:
```
[
  {
    "question": "Obowiązek udzielenia pomocy ofiarom wypadku dotyczy:",
    "answers": [
      "a) wszystkich, ponieważ zawsze można wykonać część zadań ratunkowych.",
      "b) tylko osób, które mają przygotowanie medyczne.",
      "c) wszystkich, ale za popełnione błędy zawsze grozi odpowiedzialność karna."
    ],
    "correctAnswer": 0
  },
  {
    "question": "Obowiązek udzielenia pomocy poszkodowanym w wypadku należy:",
    "answers": [
      "a) tylko do lekarzy.",
      "b) do każdej osoby.",
      "c) tylko do służb ratowniczych."
    ],
    "correctAnswer": 1
  }
]
```

# /Questions/random

### Available query parameters:
- (int) count - specify how much questions you want to receive 

## Example response
```
[
  {
    "question": "W czasie udzielania pierwszej pomocy tętno sprawdza się:",
    "answers": [
      "a) po obu stronach szyi, używając kciuka i pozostałych palców.",
      "b) po jednej stronie szyi, trzema środkowymi palcami.",
      "c) kciukiem na przegubie ręki."
    ],
    "correctAnswer": 0
  }
]
```

# /Questions/info

## Example response
```
{
  "questionCount": 35
}
```
