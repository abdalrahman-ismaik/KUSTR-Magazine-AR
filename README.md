# COSC 495: Assignment 3 - Mixed Reality & WebAR Development
This repository contains our submission for Assignment 3 of COSC 495: Introduction to Game Development. The project explores Mixed Reality (MR) features through Microsoft HoloLens and Web-based Augmented Reality (WebAR) implementations.

## Part 1: KUSTR Magazine Issue 4 WebAR Experience
This repository contains the WebAR implementation for KUSTR Magazine Issue 4 (August 2024), themed "The Rise of AI". The experience uses marker-based AR to display interactive 3D models when specific patterns in the magazine are scanned.

### Features
- **5 Interactive 3D Models**: Airplane, Chess Set, Computer Chip, Eye, and Robot Character
- **Marker-Based Tracking**: Custom pattern markers for each model
- **Interactive Elements**: Models rotate on the Y-axis and respond to touch with scaling animations
- **Information Display**: Each model shows contextual information when tapped
- **Mobile Compatibility**: Works on Chrome (Android) and Safari (iOS)

### Technical Implementation
- Built with A-Frame 1.4.2 and AR.js
- All models in GLB format hosted on GitHub
- Custom UI elements for user guidance and interaction
- Progressive loading with status feedback

### Live Demo
The WebAR experience is hosted on CodePen:

👉 ([KUSTR Magazine Issue 4 AR Experience](https://codepen.io/4bi-dev/pen/QwwjVbN))

### How to Use
1. Open the CodePen link on a mobile device
2. Allow camera access when prompted
3. Point your camera at one of the pattern markers
4. Interact with the 3D models by tapping on them
5. Toggle animations using the control buttons

## Part 2: KUSTR Magazine Issue 5 WebAR Experience
Our team created additional WebAR experiences for KUSTR Magazine Issue 5, featuring different interactive markers with unique animations and educational content.

### Features
- **Mushroom House**: Features a pulsing animation effect
- **Earth Model**: Educational content about climate change with rotating planet
- **Drone**: Includes glowing light effects and rotation
- **Hero Character**: Plays background music and displays shockwave effects
- **Jumping Whale**: Dynamic animation between two markers using Bézier curves

### Live Demo & Repository
- [WebAR Experience](https://tehsin-shaik.github.io/kurst-magazine-ar/)
- [GitHub Repository](https://github.com/tehsin-shaik/kurst-magazine-ar)

## Part 3: HoloLens MR Project
Our HoloLens Mixed Reality application integrates various MRTK features to create an immersive and interactive environment.

### Features
- **Hand Tracking & Pinch Selection**: Natural interaction through hand gestures
- **Canvas UI Elements**: Floating interface with color selection and tool buttons
- **Custom 3D Nature Scene**: Immersive environment with optimized rendering
- **Hand Mesh Overlay**: Visual feedback synchronized with user hand movements
- **Voice Commands**: Hands-free control of application features
- **RGB Sliders**: Granular color control and customization

### Project Files Link
The Unity project files for our HoloLens application can be accessed here:
- [HoloLens MR Project Files](https://drive.google.com/file/d/18H-Lwt9kTUU9qJqkWec8oclPNL5bzrgt/view)

### Team Members
- Faisal Alzarooni
- Tehsin Shaik
- Abd Alrahman Ismaik

### Course Information
- **Course**: COSC 495 - Introduction to Game Development
- **Instructors**: Dr. Lamees Alqassem and Dr. Jamal Zemerly
- **Semester**: Spring 2025
- **Assignment**: Mixed Reality & WebAR Development (Assignment 3)
