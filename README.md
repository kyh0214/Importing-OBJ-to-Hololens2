<!--Heading-->
<!--Line-->
# Importing-OBJ-to-Hololens2
*Importing OBJ via Csharp scripts to Hololens2*


This repository is made for someone who is somewhat familiar with Unity & hololens 
(Recommend you follow this repos after tutorial)

	Importing OBJ from Hololens 2
	 

##	1.유니티 프로젝트 제작
	Production Unity project
	
		a. 새 프로젝트 생성(3D, 파일 이름, 파일 위치 지정)
		Creat New Project(Setting 3D, filename, location)
		
		b. 빌드 셋팅(Universal Windows Platform, Hololens, ARM64 선택 후 Switch Platform)
		Set builds environment(Checking above 3 elememts is important) & Click the Switch Platform
		
		Shift + crtl + B 로 열수 있음(you can open also by left keys)

		
##	2. MRTK Toolkit 삽입
		a. Exe 파일을 통해 MRTK툴킷 적용 (MRTK Founation / XR 체크 확인)		
		apply MRTK via MixedRealityFeatureTool.exe (Check   MRTK Founation / OpenXR)
		
		b. Plug-In 설정 recommended 된 플러그인 선택
		setting Plug-In that (recommended) thing
				
		c. Depth 설정 / XR 설정
		setting Depth 16 bit / XR 
		
		d. New scene 생성(Basic) 및 MRTK도구 생성
		creat new scene (Basic) & add MRTK tool
		
##	3. 장면 저장 및 초기 빌드
	Save new scene / initial build
	
		a. 앱 이름 설정 / 씬 저장 (Shift + crtl + S)
		naming application /  Save scene(naming what you want)
		
		빨간 글씨 1 번은 작성자 이름 설정 2번은 생성할 앱 이름 설정
		red letter 1 is publisher name / 2 is application name
		
		b. Graphics에서 shader 추가
		adding shader in Graphics Tab
		
		Grapics > Always Included Shaders > size (+1) > Standard (Specular Setup) 찾아서 선택
		
##	4. 필요한 패키지 호출(Runtime OBJ import Package)
	Recall package what you need 
	Runtime OBJ Importer | 모델링 | Unity Asset Store
	
##	5. 스크립트 작성(Scripting)
[FilePathE.cs : Using Environmet.SpecialFolder](https://github.com/kyh0214/Importing-OBJ-to-Hololens2/blob/d2123549efda871f4cb1a141b9f43b3c9f13d76c/Importing_OBJ/Assets/FindPathE.cs)
###### C# 스크립트를 한국어로 설명


[FilePathS.cs : Using Application.streamingAssetsPath](https://github.com/kyh0214/Importing-OBJ-to-Hololens2/blob/d2123549efda871f4cb1a141b9f43b3c9f13d76c/Importing_OBJ/Assets/FindPathS.cs)
###### explain C# script by English

[SeeDebug.cs : Showing above 2 scripts filepath](https://github.com/kyh0214/Importing-OBJ-to-Hololens2/blob/d2123549efda871f4cb1a141b9f43b3c9f13d76c/Importing_OBJ/Assets/SeeDebug.cs)



##	6. 유니티 게임 내 실행 확인(Verify scripts in Unity Game mode)
##	7. 파일 빌드(새 폴더로 Builds 폴더를 만든 후 체크사항 확인 후 빌드)
	File build(Creat new folder naming what you want for build folder{I recommend naming Builds})
	
		a. 열린 씬 빌드할 때 추가(Don' forget Add Open Scenes)
		b. 모든 기기, ×64 확인 후 빌드 (Checking elements before builds )
		
##	8. 파일 내부의 홀로렌즈 권한추가 및 원격 디버깅 설정 또는 USB 연결
	Setting for debug .sln file to hololens2 
	add access permission , remote debug , usb conneting
	
		a. Release / ARM64 로 바꿀것(change build process to Release / ARM64)
		
		b. XML을 통해 가능 or 기능에서 체크(내 그림 접근 권한 부여 방법)
		(xml을 통해 파일을 열어 <uap:Capability Name="picturesLibrary"/>를 추가 OR 기능에서 그림 라이브러리 체크)
		These are ways to permit access to my Picture Library
		(through XML or Cheking Picture Library)
		
		c. 원격 연결의 경우 디버깅 속성 창에서 기기의 IP주소 할당 해주기
		In case of remoting connect assigning IP address finding from hololens 2 device
___
___

## **For more Details**

###	1. 유니티 프로젝트 제작
###	Production Unity project
	
####		a. 새 프로젝트 생성(3D, 파일 이름, 파일 위치 지정)
####		Creat New Project(Setting 3D, filename, location)

![image](https://user-images.githubusercontent.com/87642504/163777165-77733ba9-3e58-40d8-af50-e66f29bedf33.png)

####		b. 빌드 셋팅(Universal Windows Platform, Hololens, ARM64 선택 후 Switch Platform)
####		Set builds environment(Checking above 3 elememts is important) & Click the Switch Platform
![image](https://user-images.githubusercontent.com/87642504/163775923-0d8ca7ec-bbaa-4842-94e9-79f8f0dd03c7.png)

####		Shift + crtl + B 로 열수 있음(you can open also by left keys)

___		
###	2. MRTK Toolkit 삽입
####		a. Exe 파일을 통해 MRTK툴킷 적용 (MRTK Founation / OpenXR 체크 및 버전 확인)
####		apply MRTK via MixedRealityFeatureTool.exe (Check   MRTK Founation / OpenXR)
![image](https://user-images.githubusercontent.com/87642504/163776016-b5766bb5-ecfa-4a5c-aed5-1d9966405f75.png)

####		b. Plug-In 설정 recommended 된 플러그인 선택
####		setting Plug-In that (recommended) thing
![image](https://user-images.githubusercontent.com/87642504/163776060-4f7e03b7-6b6a-449a-b41a-dd6c25734eb2.png)

####	  	c. Depth 설정 / XR 설정
####		setting Depth 16 bit / XR 
![image](https://user-images.githubusercontent.com/87642504/163776081-808ccfc1-e6a1-4479-8535-9e1e06d84fe7.png)

####	  	d. New scene 생성(Basic) 및 MRTK도구 생성
####		creat new scene (Basic) & add MRTK tool
![image](https://user-images.githubusercontent.com/87642504/163776135-a02e0861-5ee7-4024-b1e7-91874c0b8c20.png)
___
###	3. 장면 저장 및 초기 빌드
####		a. 앱 이름 설정 / 씬 저장 (Shift + crtl + S)
####		naming application /  Save scene(naming what you want)
![image](https://user-images.githubusercontent.com/87642504/163776168-5d04bc40-34af-4eef-b9ad-c5fb5880723b.png)

####		빨간 글씨 1 번은 작성자 이름 설정 2번은 생성할 앱 이름 설정
####		red letter 1 is publisher name / 2 is application name
		
####		b. Graphics에서 shader 추가(adding shader in Graphics Tab)
![image](https://user-images.githubusercontent.com/87642504/163776175-acf3157d-19bc-44b9-a578-f75261ae7d92.png)

####		Grapics > Always Included Shaders > size (+1) > Standard (Specular Setup) 찾아서 선택
		
###	4. 필요한 패키지 호출(Runtime OBJ import Package)
####	Recall package what you need to use
![image](https://user-images.githubusercontent.com/87642504/163776222-5dbd8606-5c8f-47d9-aa7b-17f183296da0.png)
___
###	5. 스크립트 작성(Scripting)
___	
###	6. 유니티 게임 내 실행 확인(Verify scripts in Unity Game mode)
___	
###	7. 파일 빌드(새 폴더로 Builds 폴더를 만든 후 체크사항 확인 후 빌드)
####	File build(Creat new folder naming what you want for build folder{I recommend naming Builds})	
![image](https://user-images.githubusercontent.com/87642504/163776255-e3e25aad-8ef1-46b1-9b69-8bea8f53a47c.png)

####		a. 열린 씬 빌드할 때 추가(Don' forget Add Open Scenes)
####		b. 모든 기기, ×64 확인 후 빌드 (Checking elements before builds )
___		
###	8. 파일 내부의 홀로렌즈 권한추가 및 원격 디버깅 설정 또는 USB 연결
###	Setting for debug .sln file to hololens2 
###	add access permission , remote debug , usb conneting


####		a. Release / ARM64 로 바꿀것(change build process to Release / ARM64)
![image](https://user-images.githubusercontent.com/87642504/163776274-fd59302e-6eb1-4c3a-9e66-63956790201a.png)

####		b. XML을 통해 가능 or 기능에서 체크(내 그림 접근 권한 부여 방법)
####		(xml을 통해 파일을 열어 <uap:Capability Name="picturesLibrary"/>를 추가 OR 기능에서 그림 라이브러리 체크)
####		These are ways to permit access to my Picture Library
####		(through XML or Cheking Picture Library)
![image](https://user-images.githubusercontent.com/87642504/163776287-5c9cad2e-96f3-4058-9a4a-c95121706fef.png)

####		c. 원격 연결의 경우 디버깅 속성 창에서 기기의 IP주소 할당 해주기
####		In case of remoting connect assigning IP address finding from hololens 2 device
![image](https://user-images.githubusercontent.com/87642504/163776301-e4e91330-91d6-4410-a6f2-fcdd133c35c6.png)


