ATM 어플(?) 제작하기

구현한 기능
1.ATM 화면 구성
2.입금 기능
3.출금 기능

구현 못한 기능
1.입금 기능 중 Inputfield로 값을 받아와서 적용하기
2.출금 기능 중 Inputfield로 값을 받아와서 적용하기

pulic으로 드래그 앤 드롭으로 Inputfield를 부여할려고 했는데 드래그 앤 드롭이 안됨
그래서 public을 포기하고 Find,GetComponet로 바꿔서 진행해도 null값이 뜨며 오류


-오류수정-
Textmeshpro는 inputField가 아닌 TMP_InputField를 써야함
