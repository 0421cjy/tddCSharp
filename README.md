## The Art of Unit Testing

### 1장 단위테스트의 기본

- 단위테스트와 통합 테스트의 정의
- 간단한 단위 테스트 작성하기
- 테스트 주도 개발 탐구하기

Unit Test - '단위 테스트(unit test)'는 다른 코드를 호출한 후 몇가지 가정이 성립하는지 검사하는 코드 (대개 메서드)다. 가정이 성립하지 않는 것으로 판명되면 단위테스트는 실패한다. 여기서 '단위(unit)'라는 말은 메서드나 함수를 의미한다.

SUT - SUT는 테스트 대상 시스템을 의미한다. 어떤 사람들은 CUT[테스트 대상 클래스 (class under test) 테스트 대상 코드 (code under test)의 준말]라고 부르기도 한다. 무엇인가를 테스트할 때 그 대상을 SUT라고 부른다.

1. 좋은 단위 테스트의 속성

- 자동화되고 반복 실행이 가능해야한다.
- 구현하기 쉬워야 한다.
- 한번 작성하면 변경되지 않아야 한다.
- 누구나 실행이 가능해야한다.
- 버튼 하나를 실행이 가능해야 한다.
- 빨라야 한다.

통합 테스트 - '통합 테스트(intergration testing)'는 두 개 이상의 독립적인 소프트웨어 모듈을 하나의 그룹으로 테스트하는 것을 의미한다.

단위 테스트 <-> 통합 테스트


#Etc

프로젝트 설치 가이드 사이트  
https://www.kdata.or.kr/info/info_04_view.html?field=&keyword=&type=techreport&page=26&dbnum=181181&mode=detail&type=techreport
