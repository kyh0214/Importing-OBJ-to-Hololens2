# Importing-OBJ-to-Hololens2
Importing OBJ via Csharp scripts to Hololens2

	Importing OBJ from Hololens 2


	1. 유니티 프로젝트 제작
		a. 새 프로젝트 생성(3D, 파일 이름, 파일 위치 지정)
![image](https://user-images.githubusercontent.com/87642504/163777165-77733ba9-3e58-40d8-af50-e66f29bedf33.png)

		b. 빌드 셋팅(Universal Windows Platform, Hololens, ARM64 선택 후 Switch Platform)
![image](https://user-images.githubusercontent.com/87642504/163775923-0d8ca7ec-bbaa-4842-94e9-79f8f0dd03c7.png)

		Shift + crtl + B 로 열수 있음
		c. Founation 2.7.0 / XR 0.9.5 추가 버전 확인
		
	2. MRTK Toolkit 삽입
		a. Exe 파일을 통해 MRTK툴킷 적용 (MRTK Founation / XR 체크 확인)
![image](https://user-images.githubusercontent.com/87642504/163776016-b5766bb5-ecfa-4a5c-aed5-1d9966405f75.png)

		b. Plug-In 설정 recommended 된 플러그인 선택
![image](https://user-images.githubusercontent.com/87642504/163776060-4f7e03b7-6b6a-449a-b41a-dd6c25734eb2.png)

	  	c. Depth 설정 / XR 설정
![image](https://user-images.githubusercontent.com/87642504/163776081-808ccfc1-e6a1-4479-8535-9e1e06d84fe7.png)

	  	d. New scene 생성(Basic) 및 MRTK도구 생성
![image](https://user-images.githubusercontent.com/87642504/163776135-a02e0861-5ee7-4024-b1e7-91874c0b8c20.png)

	1. 장면 저장 및 초기 빌드
		a. 앱 이름 설정 / 씬 저장 (Shift + crtl + S)
![image](https://user-images.githubusercontent.com/87642504/163776168-5d04bc40-34af-4eef-b9ad-c5fb5880723b.png)

		1 번은 작성자 이름 설정 2번은 생성할 앱 이름 설정
		b. Graphics에서 shader 추가
![image](https://user-images.githubusercontent.com/87642504/163776175-acf3157d-19bc-44b9-a578-f75261ae7d92.png)

		Grapics > Always Included Shaders > size (+1) > Standard (Specular Setup) 찾아서 선택
	2. 필요한 패키지 호출(Runtime OBJ import Package)
Runtime OBJ Importer | 모델링 | Unity Asset Store![image](https://user-images.githubusercontent.com/87642504/163776222-5dbd8606-5c8f-47d9-aa7b-17f183296da0.png)

	3. 스크립트 작성
	4. 유니티 게임 내 실행 확인
	5. 파일 빌드(새 폴더로 Builds 폴더를 만든 후 체크사항 확인 후 빌드)
![image](https://user-images.githubusercontent.com/87642504/163776255-e3e25aad-8ef1-46b1-9b69-8bea8f53a47c.png)

		a. Add Open Scenes
		b. 모든 기기, ×64 확인 후 빌드
	6. 파일 내부의 홀로렌즈 권한추가 및 원격 디버깅 설정 또는 USB 연결
		a. Release / ARM64 로 바꿀것
![image](https://user-images.githubusercontent.com/87642504/163776274-fd59302e-6eb1-4c3a-9e66-63956790201a.png)

		b. XML을 통해 가능 or 기능에서 체크
![image](https://user-images.githubusercontent.com/87642504/163776287-5c9cad2e-96f3-4058-9a4a-c95121706fef.png)

		c. 원격 연결의 경우 디버깅 속성 창에서 기기의 IP주소 할당 해주기
![image](https://user-images.githubusercontent.com/87642504/163776301-e4e91330-91d6-4410-a6f2-fcdd133c35c6.png)


