# (C# 코딩) 그림판 (SimplePaint)
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 직선, 사각형, 원을 그리는 그림판 프로그램
- 사용한 플랫폼: 
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, GroupBox, Button, ComboBox, TrackBar, PictureBox
- 사용한 기술과 구현한 기능:
   - Visual Studio를 이용하여 UI 디자인
   - Bitmap과 Graphics 객체를 이용하여 캔버스 위에 직선, 사각형, 원을 그리는 기능 구현
   - MouseDown, MouseMove, MouseUp 이벤트를 이용하여 마우스 드래그로 도형을 그리는 기능 구현
   - DashStyle.Dash 속성을 이용하여 드래그 중 점선으로 도형 미리보기를 표시하는 기능 구현
   - ComboBox와 TrackBar를 이용하여 색상과 선 굵기를 선택하는 기능 구현
   - OpenFileDialog와 SaveFileDialog를 이용하여 이미지 파일을 불러오고 PNG, JPG, BMP 포맷으로 저장하는 기능 구현
   - MouseWheel 이벤트와 zoomFactor를 이용하여 마우스 휠로 캔버스를 확대/축소하는 기능 구현

## 실행 화면 (과제1)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/1.png)

- 구현한 내용 (위 그림 참조)
  - UI 구성 : 도형 선택, 색 선택, 선 굵기 선택, 캔버스 구성
  - 도형 선택 : 버튼 3개를 이용해서 직선, 사각형, 원을 선택할 수 있도록 구현
  - 색 선택 : ComboBox를 이용해서 검은색, 빨간색, 파란색, 초록색 선택할 수 있도록 구현
  - 선 굵기 선택 : TrackBar를 이용해서 선 굵기를 1부터 10까지 선택할 수 있도록 구현
  - 캔버스 : PictureBox를 이용해서 그림을 그릴 수 있는 영역 구성

## 실행 화면 (과제2)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/2.png)

- 구현한 내용 (위 그림 참조)
  - 도형 선택 기능 구현 : 직선, 사각형, 원 그림 그리기 기능 구현
  - 색 선택 기능 구현 : ComboBox를 이용해서 4가지 색상 중 선택한 색으로 도형 그리기 기능 구현
  - 선 굵기 선택 기능 구현 : TrackBar를 이용해서 1~10까지의 굵기 중 선택한 선 굵기로 도형 그리기 기능 구현
  - 마우스 드래그 : 마우스를 드래깅 할 떄는 점선으로 도형 표시하는 기능 구현
 

## 실행 화면 (과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/3.png)
![실행화면](img/4.png)

- 구현한 내용 (위 그림 참조)
  - 이미지 저장 기능 구현 : SaveFileDialog를 이용해서 파일 저장 대화상자를 열고 사용자가 선택한 경로에 이미지를 저장하는 기능 구현
  - 3가지 포맷 저장 : 저장 시 확장자에 따라 ImageFormat.Png로 PNG 파일을, ImageFormat.Jpeg로 JPG 파일을, ImageFormat.Bmp로 BMP 파일을 저장할 수 있도록 구현
  - 저장 버튼 이벤트 : btnSaveFile의 Click 이벤트에서 SaveFileDialog를 호출하여 canvasBitmap.Save()로 그려진 그림을 파일로 저장하도록 구현

## 실행 화면 (과제4)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/5.png)
![실행화면](img/6.png)


- 구현한 내용 (위 그림 참조)
  - 외부 이미지 불러오기 : btnOpenFile의 Click 이벤트에서 OpenFileDialog를 이용해 PNG, JPG, BMP 파일을 불러와 캔버스로 사용할 수 있도록 구현
  - 이미지 크기에 맞춰 캔버스 크기 조정 : 불러온 이미지의 Width, Height에 맞춰 Bitmap과 picCanvas 크기를 자동으로 조정하도록 구현
  - 스크롤바 : Panel(pnlCanvas)의 AutoScroll 속성을 이용해 이미지 크기가 화면보다 클 경우 스크롤바가 자동으로 생성되도록 구현
  - 마우스 휠 확대/축소 : MouseWheel 이벤트에서 zoomFactor 값을 조절하여 picCanvas의 크기를 변경하는 방식으로 확대/축소 기능을 구현
  - 확대/축소 좌표 보정 : 마우스 좌표를 zoomFactor로 나눠서 확대/축소 상태에서도 정확한 위치에 도형이 그려지도록 구현