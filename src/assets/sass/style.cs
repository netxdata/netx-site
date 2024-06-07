/*-----------------------------------------------------------------------------------

    Template Name: Creasoft - software and digital agency HTML 5 template
    Author: Egens Theme
    Author https://themeforest.net/user/egenstheme/portfolio
    Support: https://www.egenslab.com/support/
    Version: 1.0

-----------------------------------------------------------------------------------

    CSS INDEX
    ===================

    01.COMMON
    02.Header css
    03.Hero css
    04.Services css
    05.About css
    06.Feature css
    07.Project css
    08.Partner css
    09.Price plan css
    10.Testimonial css
    11.Our Team css
    12.Blog css
    13.Subscribe css
    14.Footer css 
    15.Home two css 
    16.Contact page css 
    17.Error page css 
    18.FAQ page css 
    19.Service page css
    20.Project page css 
    21.About page css 
    22.Blog page css 

-----------------------------------------------------------------------------------*/
.pt-50 {
  padding-top: 50px;
}

/*-----------------------------------------------------------------------------------
    Variables (cloned from others files)
-----------------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------------
    Custom
-----------------------------------------------------------------------------------*/
.single-partner {
  filter: grayscale(1);
}

@keyframes kenburns {
  0% {
    opacity: 0;
  }
  5% {
    opacity: 1;
  }
  95% {
    transform: scale3d(1.5, 1.5, 1.5) translate3d(-50px, -40px, 0px);
    animation-timing-function: ease-in;
    opacity: 1;
  }
  100% {
    transform: scale3d(1.5, 1.5, 1.5) translate3d(-40px, -20px, 0px);
    opacity: 0;
  }
}
.ken-burns-slideshow {
  position: absolute;
  right: 0;
  bottom: 0;
  overflow: hidden;
  width: 50%;
  border-radius: 100px 0px 0px 0px;
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .ken-burns-slideshow {
    display: none;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .ken-burns-slideshow {
    width: 45%;
    top: 50%;
    transform: translateY(-10%);
  }
}
@media only screen and (max-width: 1199px) {
  .ken-burns-slideshow {
    top: 50%;
    transform: translateY(-10%);
  }
}
.ken-burns-slideshow img {
  width: 100%;
  animation: kenburns 40s infinite;
}

/*-----------------------------------------------------------------------------------
    Mailchimp
-----------------------------------------------------------------------------------*/
#mc-embedded-subscribe-form #mc-embedded-subscribe {
  margin-top: 30px;
}

#mc-embedded-subscribe-form #gdpr_188, #mc-embedded-subscribe-form #gdpr_189 {
  width: unset !important;
}

#mc-embedded-subscribe-form .mc-checkbox {
  display: flex;
  gap: 5px;
  margin-right: 30px;
  align-items: center;
}

#mc-embedded-subscribe-form .mc-checkbox input {
  margin-bottom: unset !important;
}

#mc-embedded-subscribe-form .content__gdpr, #mc-embedded-subscribe-form .content__gdprLegal, #mc-embedded-subscribe-form .content__gdprRequired {
  font-size: 13px;
}

#mc-embedded-subscribe-form .content__gdprRequired {
  margin-bottom: 13px;
}


/*===========================
     02.Header css 
===========================*/
header {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 2;
}

.header-area {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px 100px;
  -webkit-transition: all 0.8s ease-out 0s;
  -moz-transition: all 0.8s ease-out 0s;
  -ms-transition: all 0.8s ease-out 0s;
  -o-transition: all 0.8s ease-out 0s;
  transition: all 0.8s ease-out 0s;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .header-area {
    padding: 20px 30px;
  }
}
@media (max-width: 767px) {
  .header-area {
    padding: 20px 10px;
  }
}

.logo a {
  display: inline-block;
}
.logo a img {
  max-width: 170px;
}
@media only screen and (max-width: 1199px) {
  .logo a img {
    padding: 25px 0px;
  }
}

.main-nav {
  text-align: center;
}
.main-nav ul {
  list-style: none;
}
.main-nav ul li {
  display: inline-block;
  position: relative;
  padding: 0 20px;
  color: #E4E4E4;
}
.main-nav ul li:first-child {
  padding-left: 0;
}
.main-nav ul li a {
  position: relative;
  font-family: "Saira", sans-serif;
  font-size: 15px;
  padding: 30px 0;
  font-weight: 500;
  color: #E4E4E4;
  display: inline-block;
  text-transform: capitalize;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.main-nav ul li a.active {
  color: #75DAB4;
}
.main-nav ul li a:hover {
  color: #75DAB4;
}
.main-nav ul li i {
  position: absolute;
  top: 30px;
  right: 0;
  font-size: 14px;
  text-align: center;
  z-index: 999;
  cursor: pointer;
}
.main-nav ul li ul.sub-menu {
  position: absolute;
  left: 0;
  right: 0;
  top: auto;
  margin: 0;
  opacity: 0;
  visibility: hidden;
  min-width: 200px;
  background-color: #fff;
  text-align: left;
  z-index: 9;
  box-shadow: 0px 0px 65px 0px rgba(0, 0, 0, 0.1);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  -webkit-transform: translateY(-10px);
  -moz-transform: translateY(-10px);
  -ms-transform: translateY(-10px);
  -o-transform: translateY(-10px);
  transform: translateY(-10px);
}
.main-nav ul li ul.sub-menu > li {
  padding: 0;
  display: block;
  border-bottom: 1px solid #eee;
}
.main-nav ul li ul.sub-menu > li:last-child {
  border: none;
}
.main-nav ul li ul.sub-menu > li a {
  position: relative;
  display: block;
  padding: 12px 20px;
  color: #000;
  font-weight: 400;
  text-transform: capitalize;
  font-size: 16px;
  line-height: 1;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.main-nav ul li ul.sub-menu > li a:before {
  content: "";
  position: absolute;
  bottom: 0;
  left: 0;
  background-image: linear-gradient(96.98deg, #75DAB4 0%, #FF5F45 100%);
  width: 100%;
  height: 1px;
  -webkit-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: left;
  transform-origin: left;
  -webkit-transition: 0.4s ease-in;
  transition: 0.4s ease-in;
  z-index: -1;
}
.main-nav ul li ul.sub-menu > li a.active {
  font-weight: 500;
  color: #75DAB4;
}
.main-nav ul li ul.sub-menu > li a:hover {
  color: #75DAB4;
}
.main-nav ul li ul.sub-menu > li a:hover:before {
  -webkit-transform: scale(1);
  transform: scale(1);
}
.main-nav ul li:hover ul.sub-menu {
  visibility: visible;
  opacity: 1;
  -webkit-transform: translateY(0);
  -moz-transform: translateY(0);
  -ms-transform: translateY(0);
  -o-transform: translateY(0);
  transform: translateY(0);
}

.nav-right {
  display: flex;
  align-items: center;
}

.get-qoute {
  text-align: right;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .get-qoute {
    display: inline-block;
  }
}
@media (max-width: 767px) {
  .get-qoute {
    display: none;
  }
}

/*===========================
     03.Hero css 
===========================*/
.hero-area {
  position: relative;
  height: 100vh;
  background-image: url(../img/bg.png);
  background-size: cover;
  background-position: top left;
  background-color: #191A1C;
  overflow: hidden;
}
@media (max-width: 767px) {
  .hero-area {
    height: unset;
  }
}
.hero-area .hero-shape-1 {
  position: absolute;
  left: 0;
  bottom: 0;
}
.hero-area .hero-shape-2 {
  position: absolute;
  right: 0;
  top: 0;
}
.hero-area .ken-burns-slideshow {
  position: absolute;
  right: 0;
  bottom: 0;
  overflow: hidden;
  width: 50%;
  border-radius: 100px 0px 0px 0px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .hero-area .ken-burns-slideshow {
    display: none;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .hero-area .ken-burns-slideshow {
    width: 45%;
    top: 50%;
    transform: translateY(-40%);
  }
}
@media only screen and (max-width: 1199px) {
  .hero-area .ken-burns-slideshow {
    top: 50%;
    transform: translateY(-40%);
  }
}
.hero-area .ken-burns-slideshow img {
  width: 100%;
  animation: kenburns 20s infinite;
}
.hero-area .hero-img {
  text-align: center;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .hero-area .hero-img {
    display: none;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .hero-area .hero-img img {
    width: 80%;
    margin: 0px auto;
    display: block;
  }
}

#particles-js {
  position: absolute;
  width: 100%;
  height: 100%;
}

@keyframes kenburns {
  0% {
    opacity: 0;
  }
  5% {
    opacity: 1;
  }
  95% {
    transform: scale3d(1.5, 1.5, 1.5) translate3d(-100px, -80px, 0px);
    animation-timing-function: ease-in;
    opacity: 1;
  }
  100% {
    transform: scale3d(1.5, 1.5, 1.5) translate3d(-90px, -70px, 0px);
    opacity: 0;
  }
}
.hero-wrapper {
  display: flex;
  flex-direction: column;
  justify-content: center;
  height: 100vh;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .hero-wrapper {
    padding-top: 100px;
  }
}
@media (max-width: 767px) {
  .hero-wrapper {
    height: 80vh;
  }
}

@media only screen and (min-width: 1400px) and (max-width: 1699px) {
  .hero-content {
    padding-left: 100px;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .hero-content {
    padding-left: 50px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .hero-content {
    margin-bottom: 50px;
  }
}
.hero-content.layout2 h1 {
  text-transform: capitalize;
}
.hero-content.layout2 h1 span {
  text-transform: uppercase;
}
.hero-content h1 {
  font-weight: 800;
  font-size: 52px;
  text-transform: uppercase;
  color: #E4E4E4;
  margin-bottom: 30px;
}
@media only screen and (min-width: 1400px) and (max-width: 1699px) {
  .hero-content h1 {
    font-size: 50px;
  }
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .hero-content h1 {
    font-size: 48px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .hero-content h1 {
    font-size: 40px;
  }
}
@media (max-width: 767px) {
  .hero-content h1 {
    font-size: 30px;
    line-height: 42px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .hero-content h1 {
    font-size: 40px;
  }
}
.hero-content h1 span {
  display: block;
  -webkit-text-stroke: 1px #E4E4E4;
  -webkit-text-fill-color: transparent;
  overflow: hidden;
  white-space: nowrap;
  letter-spacing: 0.15em;
  animation: typing 3.5s steps(40, end);
}
.hero-content p {
  font-weight: 400;
  font-size: 16px;
  color: #E4E4E4;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .hero-content p {
    font-size: 15px;
  }
}
@media (max-width: 767px) {
  .hero-content p {
    font-size: 14px;
  }
}

/* The typing effect */
@keyframes typing {
  from {
    width: 0;
  }
  to {
    width: 100%;
  }
}
.buttons {
  margin-top: 40px;
}
.buttons .cmn-btn {
  margin-right: 20px;
}
@media (max-width: 767px) {
  .buttons .cmn-btn {
    margin-right: 10px;
  }
}
.buttons .cmn-btn:last-child {
  margin: 0;
}

.cmn-btn.layout-two a {
  background-color: transparent;
  border: 1px solid #E4E4E4;
}

.verticale-social {
  position: absolute;
  left: -50px;
  top: 50%;
  transform: translateY(-50%);
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .verticale-social {
    left: -120px;
  }
}
@media only screen and (max-width: 1199px) {
  .verticale-social {
    left: 50px;
    top: auto;
    bottom: 50px;
  }
}
@media (max-width: 767px) {
  .verticale-social {
    left: 25px;
    top: auto;
    bottom: 50px;
  }
}

.vertical-media {
  list-style: none;
  transform: rotate(-90deg);
  display: inline-block;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .vertical-media {
    transform: none;
  }
}
.vertical-media li {
  position: relative;
  display: inline-block;
  padding: 0 20px;
}
@media (max-width: 767px) {
  .vertical-media li {
    padding: 0px 10px;
  }
}
.vertical-media li:before {
  position: absolute;
  content: "";
  height: 10px;
  width: 10px;
  border: 1px dashed #fff;
  border-radius: 50%;
  left: 0px;
  top: 35%;
  transform: translateY(-42%);
  animation-name: rotateme;
  animation-duration: 5s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  transition: all 0.2s cubic-bezier(0.98, 0.57, 1, 1) 0s;
}
@media (max-width: 767px) {
  .vertical-media li:before {
    left: -7px;
  }
}
.vertical-media li a {
  font-weight: 500;
  font-size: 16px;
  display: inline-block;
  color: #E4E4E4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .vertical-media li a {
    font-size: 14px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .vertical-media li a {
    font-size: 16px;
  }
}
.vertical-media li a:hover {
  color: #75DAB4;
}

@keyframes rotateme {
  0% {
    transform: rotate(0deg);
    opacity: 1;
  }
  50% {
    transform: rotate(180deg);
  }
  100% {
    transform: rotate(360deg);
    opacity: 1;
  }
}
/*===========================
     04.Services css 
===========================*/
.services-area {
  position: relative;
}
@media (max-width: 767px) {
  .services-area {
    margin: 80px 0 50px;
  }
}
.services-area .swiper-button-next,
.services-area .swiper-button-prev {
  top: 70%;
}
@media (max-width: 767px) {
  .services-area .swiper-button-next,
  .services-area .swiper-button-prev {
    display: none;
  }
}
.services-area .swiper-button-next:after,
.services-area .swiper-button-prev:after {
  font-size: 20px;
  height: 40px;
  min-width: 40px;
  color: #2A2A2A;
  border: 1px solid #2A2A2A;
  text-align: center;
  line-height: 40px;
  border-radius: 50%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.services-area .swiper-button-next:hover:after,
.services-area .swiper-button-prev:hover:after {
  color: #E4E4E4;
  background-color: #2A2A2A;
}
.services-area .swiper-button-next {
  right: 7%;
}
@media only screen and (min-width: 1400px) and (max-width: 1699px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .services-area .swiper-button-next {
    right: 1%;
  }
}
.services-area .swiper-button-prev {
  left: 7%;
}
@media only screen and (min-width: 1400px) and (max-width: 1699px), only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .services-area .swiper-button-prev {
    left: 1%;
  }
}

.swiper.services-slider {
  padding: 5px;
}

.single-service {
  position: relative;
  background-color: #FFFFFF;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.05);
  border-radius: 10px;
  padding: 30px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-service span {
  position: absolute;
  right: 30px;
  top: 30px;
  font-weight: 700;
  font-size: 50px;
  -webkit-text-stroke: 2px #000;
  -webkit-text-fill-color: transparent;
  opacity: 0.07;
  line-height: 1;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-service .icon {
  margin-bottom: 20px;
}
.single-service .icon img {
  height: 85px;
}
.single-service h4 {
  font-style: normal;
  font-weight: 500;
  font-size: 25px;
  color: #17161A;
  margin-bottom: 10px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-service p {
  font-weight: 400;
  font-size: 16px;
  color: #272727;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-service .read-btn {
  text-align: right;
}
.single-service .read-btn a {
  position: relative;
  font-weight: 400;
  font-size: 17px;
  color: #17161A;
  text-align: right;
  display: inline-block;
  margin-top: 20px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-service .read-btn a:before {
  position: absolute;
  content: "";
  left: -10px;
  top: -3px;
  border: 0.8px solid #75DAB4;
  box-sizing: border-box;
  height: 30px;
  width: 30px;
  border-radius: 50%;
  animation-name: rotateme;
  animation-duration: 5s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  transition: all 0.2s cubic-bezier(0.98, 0.57, 1, 1) 0s;
}
.single-service:hover {
  background-color: #0D0D0F;
}
.single-service:hover span {
  -webkit-text-stroke: 1px #75DAB4;
  -webkit-text-fill-color: transparent;
  opacity: 0.5;
}
.single-service:hover h4,
.single-service:hover p {
  color: #E4E4E4;
}
.single-service:hover .read-btn a {
  color: #E4E4E4;
}

/*===========================
     05.About css 
===========================*/
@media (max-width: 767px) {
  .about-area {
    margin-bottom: 80px;
  }
}
.about-area .sec-title {
  margin-bottom: 15px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .about-area .or-1 {
    order: 1;
  }
  .about-area .or-2 {
    order: 2;
    margin-top: 80px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) and (max-width: 767px), (max-width: 767px) and (max-width: 767px) {
  .about-area .or-2 {
    margin-top: 30px;
  }
}

.about-left h3 {
  font-weight: 500;
  font-size: 30px;
  text-transform: capitalize;
  color: #17161A;
}
@media (max-width: 767px) {
  .about-left h3 {
    font-size: 20px;
  }
}

.company-since {
  position: relative;
  background-color: #FFFFFF;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.05);
  border-radius: 20px;
  padding: 30px 50px;
  margin-top: 30px;
}
@media (max-width: 767px) {
  .company-since {
    padding: 20px;
  }
}
.company-since:before {
  position: absolute;
  content: "";
  left: -0.5px;
  top: 1.5px;
  right: -1.5px;
  bottom: 1.5px;
  background-color: #75DAB4;
  z-index: -1;
  transform: skew(0.5deg, 0.5deg);
  border-radius: 23px;
  filter: blur(1px);
}

.company-logo {
  margin-bottom: 30px;
}
.company-logo img {
  max-width: 180px;
}

.company-since strong {
  position: absolute;
  right: 50px;
  top: 20px;
  font-weight: 700;
  font-size: 26px;
  color: #17161A;
  line-height: 1;
}
.company-since h4 {
  font-weight: 500;
  font-size: 24px;
  color: #17161A;
  margin: 0;
}
@media (max-width: 767px) {
  .company-since h4 {
    font-size: 20px;
  }
}
.company-since h4 span {
  display: block;
  color: #75DAB4;
}

.about-right {
  position: relative;
}

.banner-1 {
  position: relative;
  border-radius: 40px 10px 10px 10px;
}
@media (max-width: 767px) {
  .banner-1 {
    border-radius: 10px;
  }
}

.banner-1 img {
  width: 100%;
  border-radius: 40px 10px 10px 10px;
}
@media (max-width: 767px) {
  .banner-1 img {
    border-radius: 10px;
  }
}

.banner-1:before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background-color: #0A0A0A;
  opacity: 0.5;
  border-radius: 40px 10px 10px 10px;
}
@media (max-width: 767px) {
  .banner-1:before {
    border-radius: 10px;
  }
}

.banner-2 {
  position: absolute;
  display: inline-block;
  right: 0;
  bottom: -55px;
  border-left: 10px solid #fff;
  border-top: 10px solid #fff;
  border-radius: 20px 5px 10px 15px;
}
@media (max-width: 767px) {
  .banner-2 {
    position: relative;
    text-align: center;
    margin-top: 20px;
    bottom: 0;
    border: none;
    width: 100%;
  }
}
.banner-2:before {
  position: absolute;
  content: "";
  height: 100%;
  width: 100%;
  background-color: #0A0A0A;
  opacity: 0.5;
  border-radius: 20px 5px 10px 15px;
}
@media (max-width: 767px) {
  .banner-2:before {
    border-radius: 10px;
  }
}
.banner-2 img {
  max-width: 200px;
  border-radius: 20px 5px 10px 15px;
}
@media (max-width: 767px) {
  .banner-2 img {
    width: 100%;
    max-width: none;
    border-radius: 10px;
  }
}

.banner2-inner {
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
}

.banner2-inner .play {
  display: inline-block;
  height: 40px;
  width: 40px;
  cursor: pointer;
  line-height: 40px;
  text-align: center;
  background-color: rgba(117, 218, 180, 0.3);
  font-size: 20px;
  border-radius: 50%;
  color: #75DAB4;
  animation-name: ripple;
  animation-duration: 1.5s;
  animation-iteration-count: infinite;
}
.banner2-inner .play i {
  margin-left: 4px;
}

@keyframes ripple {
  0% {
    box-shadow: 0 0 0 0 rgba(117, 218, 180, 0.3), 0 0 0 0 rgba(117, 218, 180, 0.5);
  }
  80% {
    box-shadow: 0 0 0 20px rgba(255, 255, 255, 0), 0 0 0 40px rgba(255, 255, 255, 0);
  }
  100% {
    box-shadow: 0 0 0 0 rgba(255, 255, 255, 0), 0 0 0 0 rgba(255, 255, 255, 0);
  }
}
/*===========================
     06.Feature css 
===========================*/
.features-area {
  padding: 90px 0;
  background-image: url(../img/feature-bg.png);
  background-size: cover;
  background-position: center center;
  background-color: #191A1C;
}
@media (max-width: 767px) {
  .features-area {
    padding: 80px 0;
  }
}

.single-feature {
  background-color: #0D0D0F;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
  padding: 50px 30px;
  transform: skewY(-5deg);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-feature .feature-inner {
  transform: skewY(5deg);
  text-align: center;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-feature .feature-inner .icon {
  margin-bottom: 20px;
}
.single-feature .feature-inner .icon img {
  height: 85px;
}
.single-feature .feature-inner span,
.single-feature .feature-inner sup {
  font-weight: 700;
  font-size: 35px;
  line-height: 55px;
  color: #E4E4E4;
}
.single-feature .feature-inner sup {
  top: -10px;
}
.single-feature .feature-inner h4 {
  font-weight: 500;
  font-size: 20px;
  text-transform: capitalize;
  color: #E4E4E4;
  margin-top: 5px;
  margin-bottom: 0;
}
.single-feature:hover {
  transform: skewY(0deg);
}
.single-feature:hover .feature-inner {
  transform: skewY(0deg);
}

/*===========================
     07.Project css 
===========================*/
@media (max-width: 767px) {
  .project-area {
    margin: 80px 0;
  }
}

.isotope-menu {
  text-align: center;
  list-style: none;
  margin-bottom: 40px;
}
.isotope-menu li {
  display: inline-block;
  font-weight: 600;
  font-size: 16px;
  color: #E4E4E4;
  cursor: pointer;
  background: #191A1C;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
  padding: 10px 30px;
  margin: 0 10px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .isotope-menu li {
    font-size: 14px;
    margin: 0 5px;
  }
}
@media (max-width: 767px) {
  .isotope-menu li {
    font-size: 14px;
    padding: 15px 20px;
    margin: 10px 5px;
  }
}
.isotope-menu li.active {
  color: #191A1C;
  background-color: #75DAB4;
}
.isotope-menu li:hover {
  color: #191A1C;
  background-color: #75DAB4;
}

.single-item {
  position: relative;
}
.single-item .item-img a img {
  width: 100%;
  border-radius: 10px;
}
.single-item .item-inner-cnt {
  background-color: #0F0F11;
  border-radius: 5px;
  padding: 20px;
  width: 90%;
  left: 5%;
  position: absolute;
  bottom: 5%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-item .item-inner-cnt span {
  font-weight: 500;
  font-size: 15px;
  display: inline-block;
  color: #E4E4E4;
  border-bottom: 1px solid #75DAB4;
  padding-bottom: 2px;
  margin-bottom: 10px;
}
.single-item .item-inner-cnt h4 {
  font-weight: 600;
  font-size: 22px;
  text-transform: capitalize;
  color: #E4E4E4;
  margin: 0;
}
.single-item .item-inner-cnt .view-btn {
  text-align: right;
  visibility: hidden;
  opacity: 0;
  height: 0;
  transform: translateY(-100%);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-item .item-inner-cnt .view-btn a {
  position: relative;
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  color: #E4E4E4;
  display: inline-block;
  text-transform: capitalize;
}
.single-item .item-inner-cnt .view-btn a:before {
  position: absolute;
  content: "";
  left: -10px;
  top: -3px;
  border: 0.8px solid #75DAB4;
  box-sizing: border-box;
  height: 30px;
  width: 30px;
  border-radius: 50%;
  animation-name: rotateme;
  animation-duration: 5s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  transition: all 0.2s cubic-bezier(0.98, 0.57, 1, 1) 0s;
}
.single-item:hover .item-inner-cnt .view-btn {
  margin-top: 20px;
  visibility: visible;
  opacity: 1;
  height: auto;
  transform: translateY(0%);
}

/*===========================
     08.Partner css 
===========================*/
.our-partner {
  padding: 100px 0;
  background-color: #191A1C;
}
@media (max-width: 767px) {
  .our-partner {
    padding: 80px 0;
  }
}
.our-partner .sec-title {
  margin-bottom: 10px;
  border-right: 1px solid #75DAB4;
}
.our-partner .sec-title .swiper-button-next-c,
.our-partner .sec-title .swiper-button-prev-c {
  color: #E4E4E4;
  font-size: 16px;
  display: inline-block;
  height: 40px;
  width: 40px;
  background-color: #0D0D0F;
  border-radius: 50%;
  line-height: 40px;
  text-align: center;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.our-partner .sec-title .swiper-button-next-c:hover,
.our-partner .sec-title .swiper-button-prev-c:hover {
  color: #000;
  background-color: #75DAB4;
}
.our-partner .sec-title .swiper-button-prev-c {
  margin-right: 20px;
}

.single-partner {
  background-color: #0D0D0F;
  border: 1px solid #191A1C;
  box-sizing: border-box;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
  min-height: 114px;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 20px;
}
.single-partner img {
  height: auto;
  width: auto;
}

/*===========================
     09.Price plan css 
===========================*/
@media (max-width: 767px) {
  .priceing-plan {
    margin: 80px 0;
  }
}

.price-table-tab {
  margin-bottom: 40px;
}

.nav.nav-pills {
  justify-content: center;
}
.nav.nav-pills .nav-item .nav-link {
  background-color: #191A1C;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
  min-width: 170px;
  padding: 10px 30px;
  margin: 0 15px;
  font-weight: 600;
  font-size: 17px;
  color: #E4E4E4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .nav.nav-pills .nav-item .nav-link {
    font-size: 14px;
    min-width: 125px;
    padding: 15px 20px;
    margin: 0px 10px;
  }
}
.nav.nav-pills .nav-item .nav-link.active {
  background-color: #75DAB4;
  color: #191A1C;
}
.nav.nav-pills .nav-item .nav-link:hover {
  background-color: #75DAB4;
  color: #191A1C;
}

.price-box {
  background-color: #FFFFFF;
  box-shadow: 0px 0px 40px rgba(33, 33, 33, 0.1);
  border-radius: 10px;
  padding: 40px;
  text-align: center;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .price-box {
    padding: 40px 20px;
  }
}
.price-box.layout2 h3:before {
  position: absolute;
  content: "";
  left: 50%;
  bottom: -10px;
  width: 150px;
  height: 2px;
  transform: translateX(-50%);
  background: linear-gradient(90deg, #181818, #75DAB4, #181818);
}
.price-box h3 {
  position: relative;
  font-weight: 700;
  font-size: 32px;
  color: #17161A;
  margin-bottom: 30px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.price-box h3:before {
  position: absolute;
  content: "";
  left: 50%;
  bottom: -10px;
  width: 150px;
  height: 2px;
  transform: translateX(-50%);
  background: linear-gradient(90deg, #fff, #75DAB4, #fff);
}
.price-box span {
  font-weight: 400;
  font-size: 18px;
  color: #17161A;
  display: block;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.price-box strong {
  font-weight: 700;
  font-size: 38px;
  color: #17161A;
  display: block;
  margin: 20px 0;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.price-box strong sub {
  color: #75DAB4;
  font-size: 16px;
  font-weight: 400;
}
.price-box:hover {
  background-color: #191A1C;
  border-radius: 10px;
}
.price-box:hover h3 {
  color: #E4E4E4;
}
.price-box:hover h3:before {
  position: absolute;
  content: "";
  left: 50%;
  bottom: -10px;
  width: 150px;
  height: 2px;
  transform: translateX(-50%);
  background: linear-gradient(90deg, #181818, #75DAB4, #181818);
}
.price-box:hover h3,
.price-box:hover span,
.price-box:hover strong {
  color: #E4E4E4;
}
.price-box:hover .item-list li {
  color: #E4E4E4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.price-box:hover .price-btn a {
  color: #000;
  background-color: #75DAB4;
}

.item-list li {
  font-size: 16px;
  color: #17161A;
  margin-bottom: 15px;
}
.item-list li:last-child {
  margin: 0;
}
.item-list li i {
  margin-right: 5px;
  font-size: 18px;
}

.price-btn {
  position: relative;
  display: inline-block;
  margin-top: 40px;
}
.price-btn a {
  background-color: #17161A;
  border-radius: 5px;
  font-weight: 700;
  font-size: 17px;
  display: inline-block;
  text-align: center;
  color: #FFFFFF;
  min-width: 200px;
  padding: 10px 30px;
  transition: transition(0.5s);
}
.price-btn .line-1 {
  position: absolute;
  right: 8px;
  top: 8px;
  z-index: 2;
}
.price-btn .line-1:before {
  position: absolute;
  content: "";
  border: 1px solid #FFFFFF;
  width: 25px;
  opacity: 0.1;
  right: 0;
}
.price-btn .line-1:after {
  position: absolute;
  content: "";
  border: 1px solid #FFFFFF;
  height: 25px;
  opacity: 0.1;
}
.price-btn .line-2 {
  position: absolute;
  left: 8px;
  bottom: 10px;
  z-index: 2;
}
.price-btn .line-2:before {
  position: absolute;
  content: "";
  border: 1px solid #FFFFFF;
  height: 25px;
  opacity: 0.1;
  right: 0px;
  bottom: -2px;
}
.price-btn .line-2:after {
  position: absolute;
  content: "";
  border: 1px solid #FFFFFF;
  width: 25px;
  opacity: 0.1;
  left: 0px;
}

/*===========================
     10.Testimonial css
===========================*/
.testimonial-area {
  background-color: #191A1C;
  padding: 100px 0;
  position: relative;
}
@media (max-width: 767px) {
  .testimonial-area {
    padding: 80px 0;
  }
}
.testimonial-area .swiper-button-next,
.testimonial-area .swiper-button-prev {
  top: 62%;
}
@media (max-width: 576px) {
  .testimonial-area .swiper-button-next,
  .testimonial-area .swiper-button-prev {
    display: none;
    visibility: hidden;
  }
}
.testimonial-area .swiper-button-next:after,
.testimonial-area .swiper-button-prev:after {
  font-size: 20px;
  height: 40px;
  min-width: 40px;
  color: #E4E4E4;
  background-color: #2A2A2A;
  border: 1px solid #2A2A2A;
  text-align: center;
  line-height: 40px;
  border-radius: 50%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.testimonial-area .swiper-button-next:hover:after,
.testimonial-area .swiper-button-prev:hover:after {
  color: #000;
  border: none;
  background-color: #75DAB4;
}
.testimonial-area .swiper-button-next {
  right: 7%;
}
.testimonial-area .swiper-button-prev {
  left: 7%;
}

.swiper.testimonial-slider .swiper-slide {
  opacity: 0.4;
}
.swiper.testimonial-slider .swiper-slide.swiper-slide-active {
  opacity: 1;
}

.single-testimonial {
  position: relative;
  background-color: #0D0D0F;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
  padding: 45px 20px;
}
.single-testimonial h5 {
  font-weight: 600;
  font-size: 25px;
  color: #E4E4E4;
  margin-bottom: 5px;
}
.single-testimonial span {
  font-weight: 400;
  font-size: 17px;
  color: #5F6062;
}
.single-testimonial p {
  color: #E4E4E4;
  font-size: 15px;
  margin: 30px 0;
}

.stars {
  position: absolute;
  top: 45px;
  right: 20px;
}
@media (max-width: 767px) {
  .stars {
    position: static;
    margin-top: 25px;
  }
}
.stars a {
  display: inline-block;
  color: #FFC107;
}

.quote {
  position: absolute;
  right: 20px;
  bottom: 45px;
}
.quote i {
  color: #E4E4E4;
  font-size: 80px;
  opacity: 0.1;
}

.reviewer img {
  height: 80px;
  width: 80px;
  border-radius: 50%;
}

/*===========================
     11.Our Team css
===========================*/
@media (max-width: 767px) {
  .our-team {
    margin: 80px 0;
  }
}

.swiper.services-slider {
  padding: 5px 5px 50px 5px;
}
.swiper.services-slider .swiper-pagination {
  bottom: -5px !important;
}
.swiper.services-slider .swiper-pagination .swiper-pagination-bullet {
  background-color: transparent;
  height: 15px;
  width: 15px;
  border: 0.8px solid #75DAB4;
  opacity: 1;
}
.swiper.services-slider .swiper-pagination .swiper-pagination-bullet-active {
  position: relative;
}
.swiper.services-slider .swiper-pagination .swiper-pagination-bullet-active:before {
  position: absolute;
  content: "";
  left: 50%;
  top: 50%;
  height: 5px;
  width: 5px;
  background-color: #75DAB4;
  border-radius: 50%;
  transform: translate(-62%, -62%);
}
@media (max-width: 991px) {
  .swiper.services-slider .swiper-pagination .swiper-pagination-bullet-active:before {
    transform: translate(-62%, -42%);
  }
}

.swiper.testimonial-slider {
  padding: 5px 5px 50px 5px;
}
.swiper.testimonial-slider .swiper-pagination {
  bottom: -5px !important;
}
.swiper.testimonial-slider .swiper-pagination .swiper-pagination-bullet {
  background-color: transparent;
  height: 15px;
  width: 15px;
  border: 0.8px solid #75DAB4;
  opacity: 1;
}
.swiper.testimonial-slider .swiper-pagination .swiper-pagination-bullet-active {
  position: relative;
}
.swiper.testimonial-slider .swiper-pagination .swiper-pagination-bullet-active:before {
  position: absolute;
  content: "";
  left: 50%;
  top: 50%;
  height: 5px;
  width: 5px;
  background-color: #75DAB4;
  border-radius: 50%;
  transform: translate(-62%, -62%);
}
@media (max-width: 991px) {
  .swiper.testimonial-slider .swiper-pagination .swiper-pagination-bullet-active:before {
    transform: translate(-62%, -42%);
  }
}

.swiper.team-slider {
  padding: 5px 5px 50px 5px;
}
.swiper.team-slider .swiper-pagination {
  bottom: -5px !important;
}
.swiper.team-slider .swiper-pagination .swiper-pagination-bullet {
  background-color: transparent;
  height: 15px;
  width: 15px;
  border: 0.8px solid #75DAB4;
  opacity: 1;
}
.swiper.team-slider .swiper-pagination .swiper-pagination-bullet-active {
  position: relative;
}
.swiper.team-slider .swiper-pagination .swiper-pagination-bullet-active:before {
  position: absolute;
  content: "";
  left: 50%;
  top: 50%;
  height: 5px;
  width: 5px;
  background-color: #75DAB4;
  border-radius: 50%;
  transform: translate(-62%, -62%);
}
@media (max-width: 991px) {
  .swiper.team-slider .swiper-pagination .swiper-pagination-bullet-active:before {
    transform: translate(-62%, -42%);
  }
}

.single-team {
  position: relative;
}
.single-team:hover .member-img:before {
  visibility: visible;
  opacity: 0.8;
  transform: translateY(0);
}
.single-team:hover .member-img img {
  transform: scale(1.1);
}
.single-team:hover .member-img svg {
  visibility: visible;
  opacity: 1;
  transform: translateX(0);
}
.single-team:hover .member-img .team-social {
  visibility: visible;
  opacity: 1;
  transform: translateY(-50%);
}
.single-team:hover .team-inner {
  background-color: #191A1C;
}
.single-team:hover .team-inner h4 {
  color: #E4E4E4;
}
.single-team:hover .team-inner span {
  color: #75DAB4;
}

.member-img {
  position: relative;
  border-radius: 10px 10px 0px 0px;
  overflow: hidden;
}
.member-img:before {
  position: absolute;
  content: "";
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  background-color: #191A1C;
  border-radius: 10px 10px 0px 0px;
  visibility: hidden;
  opacity: 0;
  z-index: 1;
  transform: translateY(-100%);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.member-img img {
  width: 100%;
  border-radius: 10px 10px 0px 0px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.member-img svg {
  position: absolute;
  top: 0;
  left: 0;
  visibility: hidden;
  opacity: 0;
  transform: translateX(-100%);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.member-img svg path {
  fill: #191A1C;
}
.member-img .team-social {
  position: absolute;
  left: 15px;
  top: 50%;
  z-index: 2;
  visibility: hidden;
  opacity: 0;
  transform: translateY(-100%);
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.member-img .team-social li {
  margin: 10px 0;
}
.member-img .team-social li a {
  display: inline-block;
  height: 30px;
  width: 30px;
  line-height: 30px;
  text-align: center;
  background-color: #0F1012;
  border-radius: 50%;
  font-size: 14px;
  color: #E4E4E4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.member-img .team-social li a:hover {
  background-color: #75DAB4;
  color: #0F1012;
}

.team-inner {
  background-color: #FFFFFF;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.05);
  border-radius: 0px 0px 10px 10px;
  padding: 20px;
  text-align: center;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.team-inner h4 {
  font-weight: 600;
  font-size: 25px;
  color: #17161A;
  margin-bottom: 5px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .team-inner h4 {
    font-size: 24px;
  }
}
.team-inner span {
  font-size: 17px;
  color: #5F6062;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}

/*===========================
     12.Blog css
===========================*/
.single-blog .blog-thumb {
  position: relative;
  overflow: hidden;
  border-radius: 10px 10px 0px 0px;
}
.single-blog .blog-thumb a img {
  border-radius: 10px 10px 0px 0px;
  width: 100%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-blog .blog-thumb .tag {
  position: absolute;
  top: 20px;
  left: 20px;
}
.single-blog .blog-thumb .tag a {
  font-weight: 600;
  font-size: 15px;
  display: inline-block;
  text-align: center;
  color: #0F1012;
  background-color: #75DAB4;
  padding: 5px 15px;
  border-radius: 30px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-blog .blog-thumb .tag a:hover {
  background-color: #fff;
  color: #75DAB4;
}
.single-blog .blog-inner {
  padding: 20px;
  background: #FFFFFF;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.05);
  border-radius: 0px 0px 10px 10px;
}
.single-blog .blog-inner h4 {
  margin-top: 15px;
  margin-bottom: 5px;
}
.single-blog .blog-inner h4 a {
  font-weight: 600;
  font-size: 22px;
  display: inline-block;
  text-transform: capitalize;
  color: #17161A;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-blog .blog-inner h4 a:hover {
  color: #75DAB4;
}
.single-blog .blog-inner .author-date {
  display: flex;
  justify-content: space-between;
}
.single-blog .blog-inner .author-date a {
  font-weight: 500;
  font-size: 17px;
  text-transform: capitalize;
  color: #5F6062;
  display: inline-block;
}
@media (max-width: 767px) {
  .single-blog .blog-inner .author-date a.cmnt {
    display: none;
  }
}
.single-blog:hover .blog-thumb a img {
  transform: scale(1.1) skewY(5deg);
}

/*===========================
     13.Subscribe css
===========================*/
.subscribe-newsletter {
  position: relative;
  z-index: 1;
}
@media (max-width: 767px) {
  .subscribe-newsletter {
    margin-top: 80px;
  }
}

.news-letter-content {
  position: relative;
  padding: 60px 80px;
  border-radius: 10px;
  background-color: #1A191D;
  background-image: url(../img/subscribe-bg.png);
  background-size: cover;
  background-position: center center;
}
@media (max-width: 767px) {
  .news-letter-content {
    padding: 30px 20px;
  }
}

.subscribe-cnt span {
  font-weight: 600;
  font-size: 20px;
  display: block;
  text-transform: capitalize;
  color: #75DAB4;
}
.subscribe-cnt h3 {
  font-weight: 700;
  font-size: 45px;
  text-transform: uppercase;
  color: #E4E4E4;
  margin-bottom: 5px;
}
@media (max-width: 767px) {
  .subscribe-cnt h3 {
    font-size: 30px;
  }
}
.subscribe-cnt strong {
  -webkit-text-stroke: 1px #5F5F5F;
  -webkit-text-fill-color: transparent;
  font-size: 45px;
  text-transform: uppercase;
  font-weight: 700;
}
@media (max-width: 767px) {
  .subscribe-cnt strong {
    font-size: 30px;
  }
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .subscribe-form {
    margin-top: 15px;
  }
}
.subscribe-form form {
  position: relative;
}
.subscribe-form form input {
  height: 60px;
  width: 100%;
  background-color: #0F0F11;
  border-radius: 10px;
  border: none;
  padding: 0 20px;
  color: #E4E4E4;
}
.subscribe-form form input[type=email] {
  padding-right: 160px;
}
@media (max-width: 767px) {
  .subscribe-form form input[type=email] {
    padding: 0 10px;
  }
}
.subscribe-form form input[type=submit] {
  max-width: 140px;
  background-color: #75DAB4;
  border-radius: 10px;
  position: absolute;
  right: 5px;
  height: 50px;
  top: 5px;
  color: #000;
  font-size: 16px;
  font-weight: 600;
  text-transform: uppercase;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .subscribe-form form input[type=submit] {
    position: static;
    margin-top: 15px;
  }
}
.subscribe-form form input[type=submit]:hover {
  color: #75DAB4;
  background-color: #fff;
}

/*===========================
     14.Footer css 
===========================*/
footer {
  position: relative;
  padding-top: 100px;
  margin-top: -100px;
  background-image: url(../img/footer-bg.png);
  background-size: cover;
  background-position: center center;
  background-color: #191A1C;
}
footer.error {
  padding-top: 0;
  margin-top: 0;
}

.footer-top {
  padding-top: 100px;
}
@media (max-width: 767px) {
  .footer-top {
    padding-top: 80px;
  }
}

@media (max-width: 767px) {
  .footer-widget {
    margin-bottom: 50px;
  }
}
.footer-widget .footer-logo {
  margin-bottom: 30px;
}
.footer-widget .footer-logo a img {
  width: auto;
}
.footer-widget h4 {
  font-weight: 700;
  font-size: 25px;
  color: #E4E4E4;
  margin-bottom: 30px;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .footer-widget h4 {
    font-size: 24px;
  }
}
.footer-widget p {
  font-weight: 300;
  font-size: 16px;
  color: #E4E4E4;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .footer-widget p {
    font-size: 14px;
  }
}

.social-media-icons {
  list-style: none;
  margin-top: 30px;
}
.social-media-icons li {
  display: inline-block;
  padding-right: 30px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .social-media-icons li {
    padding-right: 25px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .social-media-icons li {
    padding-right: 15px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .social-media-icons li {
    padding-right: 5px;
  }
}
.social-media-icons li a {
  display: inline-block;
  box-sizing: border-box;
  border-radius: 10px;
  height: 35px;
  width: 35px;
  line-height: 35px;
  text-align: center;
  color: #E4E4E4;
  background: #0F1012;
  -webkit-transition: all 0.8s ease-out 0s;
  -moz-transition: all 0.8s ease-out 0s;
  -ms-transition: all 0.8s ease-out 0s;
  -o-transition: all 0.8s ease-out 0s;
  transition: all 0.8s ease-out 0s;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .social-media-icons li a {
    height: 30px;
    width: 30px;
    line-height: 30px;
  }
}
.social-media-icons li a:hover {
  color: #0F1012;
  background-color: #75DAB4;
  -webkit-transform: rotate(360deg);
  -moz-transform: rotate(360deg);
  -ms-transform: rotate(360deg);
  -o-transform: rotate(360deg);
  transform: rotate(360deg);
}

.footer-menu {
  list-style: none;
}
.footer-menu li {
  display: block;
  padding-bottom: 15px;
}
.footer-menu li:last-child {
  padding-bottom: 0;
}
.footer-menu li a {
  position: relative;
  font-weight: 500;
  font-size: 16px;
  color: #E4E4E4;
  display: inline-block;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .footer-menu li a {
    font-size: 15px;
  }
}
.footer-menu li a:before {
  position: absolute;
  content: "";
  top: 50%;
  -webkit-transform: translateY(-50%);
  -moz-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  -o-transform: translateY(-50%);
  transform: translateY(-50%);
  left: -20px;
  height: 10px;
  width: 10px;
  background-color: #75DAB4;
  border-radius: 50%;
  visibility: hidden;
  opacity: 0;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.footer-menu li a:hover {
  color: #75DAB4;
  padding-left: 15px;
}
.footer-menu li a:hover:before {
  left: 0;
  visibility: visible;
  opacity: 1;
}

.number,
.office-mail,
.address {
  display: flex;
  width: 100%;
  align-items: center;
  margin-bottom: 20px;
}
.number p,
.office-mail p,
.address p {
  font-weight: 500;
  font-size: 17px;
  letter-spacing: 0.03em;
  color: #E4E4E4;
  margin: 0;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .number p,
  .office-mail p,
  .address p {
    font-size: 14px;
  }
}

.phone a,
.email a {
  font-weight: 500;
  font-size: 17px;
  letter-spacing: 0.03em;
  color: #E4E4E4;
  display: block;
  padding-bottom: 5px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .phone a,
  .email a {
    font-size: 13px;
  }
}
.phone a:hover,
.email a:hover {
  color: #75DAB4;
}

.num-icon,
.mail-icon,
.address-icon {
  min-width: 40px;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .num-icon,
  .mail-icon,
  .address-icon {
    min-width: 30px;
  }
}
.num-icon i,
.mail-icon i,
.address-icon i {
  color: #75DAB4;
  font-size: 25px;
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .num-icon i,
  .mail-icon i,
  .address-icon i {
    font-size: 20px;
  }
}

.footer-bottom {
  margin-top: 80px;
  padding: 30px 0;
  border-top: 2px solid #292929;
}
@media (max-width: 767px) {
  .footer-bottom {
    margin-top: 30px !important;
  }
}
@media (max-width: 767px) {
  .footer-bottom .copy-txt {
    text-align: center;
  }
}
.footer-bottom .copy-txt span {
  font-size: 14px;
  color: #E4E4E4;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .footer-bottom .copy-txt span {
    font-size: 13px;
  }
}
@media (max-width: 767px) {
  .footer-bottom .copy-txt span {
    font-size: 13px;
  }
}
.footer-bottom .copy-txt span a {
  font-weight: 700;
  color: #E4E4E4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.footer-bottom .copy-txt span a:hover {
  color: #75DAB4;
}
.footer-bottom .footer-bottom-menu {
  list-style: none;
  text-align: right;
}
@media (max-width: 767px) {
  .footer-bottom .footer-bottom-menu {
    margin-top: 30px;
    text-align: center;
  }
}
.footer-bottom .footer-bottom-menu li {
  display: inline-block;
}
.footer-bottom .footer-bottom-menu li a {
  position: relative;
  font-size: 14px;
  text-align: right;
  letter-spacing: 0.01em;
  color: #E4E4E4;
  padding: 0 20px;
  line-height: 1;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .footer-bottom .footer-bottom-menu li a {
    padding: 0;
    padding-right: 10px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .footer-bottom .footer-bottom-menu li a {
    padding: 0 20px;
  }
}
.footer-bottom .footer-bottom-menu li a:before {
  border-right: 1px solid #fff;
  position: absolute;
  content: "";
  height: 60%;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}
@media (max-width: 767px) {
  .footer-bottom .footer-bottom-menu li a:before {
    display: none;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .footer-bottom .footer-bottom-menu li a:before {
    display: block;
  }
}
.footer-bottom .footer-bottom-menu li a:hover {
  color: #75DAB4;
}
.footer-bottom .footer-bottom-menu li:last-child a:before {
  display: none;
}

/*===========================
     15.Home two css 
===========================*/
.creasoft-wrap.layout2 {
  background-image: url(../img/black-concrete-textured.png);
  background-repeat: repeat;
  background-color: #000000;
}

.services-area.layout2 .swiper-button-next::after,
.services-area.layout2 .swiper-button-prev::after {
  background-color: #2A2A2A;
  color: #E4E4E4;
}

.single-service.layout2 {
  position: relative;
  background-color: #0D0D0E;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
}
.single-service.layout2:hover {
  background: linear-gradient(152.97deg, rgba(255, 255, 255, 0.2) 0%, rgba(255, 255, 255, 0) 100%);
  backdrop-filter: blur(42px);
  border-radius: 10px;
}

.single-service.layout2 h4 {
  color: #E4E4E4;
}

.single-service.layout2 p {
  color: #E4E4E4;
}

.single-service.layout2 .read-btn a {
  color: #E4E4E4;
}

.single-service.layout2 span {
  -webkit-text-stroke: 2px #75DAB4;
  opacity: 0.15;
}

.about-left.layout2 h3 {
  color: #E4E4E4;
}

.about-left.layout2 p {
  color: #E4E4E4;
}

.company-since.layout2 {
  background: #0D0D0F;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 20px;
}

.company-since.layout2 h4 {
  color: #E4E4E4;
}

.company-since.layout2 strong {
  color: #E4E4E4;
}

.about-right.layout2 .banner-2 {
  border-left: 10px solid #000;
  border-top: 10px solid #000;
}
@media (max-width: 767px) {
  .about-right.layout2 .banner-2 {
    border: none;
  }
}

.isotope-menu.layout2 li.active {
  position: relative;
  color: #fff;
  background-color: #0D0D0F;
}
.isotope-menu.layout2 li.active:before {
  position: absolute;
  content: "";
  left: -1px;
  top: -1px;
  right: -1px;
  bottom: -0.5px;
  background-color: #75DAB4;
  z-index: -1;
  transform: skew(1deg, 1deg);
  border-radius: 12px;
}

.price-table-tab.layout2 .nav.nav-pills .nav-item .nav-link.active {
  position: relative;
  background-color: #191A1C;
  color: #fff;
}
.price-table-tab.layout2 .nav.nav-pills .nav-item .nav-link.active:before {
  position: absolute;
  content: "";
  left: -1px;
  top: -0.5px;
  right: -1px;
  bottom: -0.5px;
  background-color: #75DAB4;
  z-index: -1;
  transform: skew(1deg, 1deg);
  border-radius: 12px;
}

.nav.nav-pills .nav-item .nav-link.active {
  position: relative;
  background-color: #75DAB4;
  color: #fff;
}

.price-box.layout2 {
  background-color: #0D0D0F;
  box-shadow: inset 0px 0px 10px rgba(6, 6, 6, 0.15);
  border-radius: 10px;
}
.price-box.layout2 h3,
.price-box.layout2 span,
.price-box.layout2 strong {
  color: #fff;
}
.price-box.layout2 .item-list li {
  color: #fff;
}
.price-box.layout2:hover {
  background-color: #191A1C;
}

.single-team.layout2 .team-inner {
  background-color: #191A1C;
}
.single-team.layout2 .team-inner h4 {
  color: #E4E4E4;
}
.single-team.layout2 .team-inner span {
  color: #5F6062;
}

.single-blog.layout2 .blog-inner {
  background: transparent;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-blog.layout2 .blog-inner .author-date a {
  color: #5F6062;
}
.single-blog.layout2 .blog-inner h4 a {
  color: #E4E4E4;
}
.single-blog.layout2:hover .blog-inner {
  background: linear-gradient(357.81deg, rgba(39, 39, 46, 0.6445) 1.75%, rgba(74, 75, 86, 0.0072) 98.16%);
  border-radius: 0px 0px 10px 10px;
}

/*===========================
     16.Contact page css 
===========================*/
@media (max-width: 767px) {
  .contact-area {
    margin: 80px 0;
  }
}

@media (max-width: 767px) {
  .contact-left {
    margin-bottom: 50px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .contact-left .sec-title h2 {
    font-size: 30px;
  }
}

.social-follow {
  list-style: none;
}
.social-follow li {
  display: inline-block;
}
.social-follow li a {
  height: 40px;
  width: 40px;
  line-height: 40px;
  text-align: center;
  display: inline-block;
  color: #fff;
  background-color: #17161A;
  font-size: 14px;
  border-radius: 10px;
  margin-right: 15px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.social-follow li a:hover {
  background-color: #75DAB4;
}

.informations {
  margin-top: 50px;
}

.single-info {
  display: flex;
  width: 100%;
  align-items: center;
  margin-bottom: 30px;
}
.single-info:last-child {
  margin-bottom: 0;
}
.single-info .icon {
  min-width: 100px;
}
.single-info .icon i {
  height: 80px;
  width: 80px;
  line-height: 80px;
  font-size: 30px;
  text-align: center;
  background-color: rgba(23, 22, 26, 0.1);
  border-radius: 50%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.single-info:hover .icon i {
  color: #75dab4;
  background-color: rgba(117, 218, 180, 0.1);
}

.info h3 {
  font-size: 30px;
  font-weight: 600;
  color: #17161A;
  text-transform: capitalize;
  margin-bottom: 10px;
}
.info p {
  font-size: 16px;
  font-weight: 500;
  color: #272727;
}
.info a {
  font-size: 16px;
  font-weight: 500;
  color: #272727;
  display: block;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.info a:hover {
  color: #75DAB4;
}

.mapouter .gmap_canvas iframe {
  height: 620px;
  width: 100%;
}
@media (max-width: 767px) {
  .mapouter .gmap_canvas iframe {
    height: 320px;
  }
}

.getin-touch {
  margin-top: 120px;
}
@media (max-width: 767px) {
  .getin-touch {
    margin-top: 80px;
  }
}
.getin-touch .contact-form h3 {
  font-weight: 700;
  font-size: 30px;
  text-transform: uppercase;
  color: #17161A;
  margin-bottom: 50px;
}
@media (max-width: 767px) {
  .getin-touch .contact-form h3 {
    font-size: 24px;
  }
}
.getin-touch .contact-form form input,
.getin-touch .contact-form form textarea {
  background-color: #FFFFFF;
  border: 1px solid #E9E9E9;
  box-sizing: border-box;
  height: 60px;
  width: 100%;
  padding: 0 15px;
  margin-bottom: 30px;
}
.getin-touch .contact-form form input[type=submit],
.getin-touch .contact-form form textarea[type=submit] {
  background-color: #17161A;
  border-radius: 30px;
  max-width: 180px;
  font-weight: 600;
  font-size: 16px;
  text-align: center;
  color: #FFFFFF;
  border: none;
  border: none;
  margin: 0;
}
.getin-touch .contact-form form textarea {
  height: 150px;
  padding: 15px;
  resize: none;
}
@media (max-width: 767px) {
  .getin-touch .call-banner {
    display: none;
  }
}
.getin-touch .call-banner img {
  width: 100%;
}

/*===========================
     17.Error page css 
===========================*/
.back-to-home {
  background-image: url(../img/error-bg.png);
  background-size: cover;
  background-position: top left;
}
@media (max-width: 767px) {
  .back-to-home {
    padding: 80px 0;
  }
}

.error-wrapper {
  text-align: center;
}
.error-wrapper img {
  max-width: 500px;
  margin-bottom: 50px;
}
@media (max-width: 767px) {
  .error-wrapper img {
    max-width: 100%;
  }
}
.error-wrapper h3 {
  font-weight: 700;
  font-size: 50px;
  text-align: center;
  text-transform: uppercase;
  color: #272727;
  margin-bottom: 20px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px), only screen and (min-width: 768px) and (max-width: 991px) {
  .error-wrapper h3 {
    font-size: 40px;
  }
}
@media (max-width: 767px) {
  .error-wrapper h3 {
    font-size: 30px;
  }
}
.error-wrapper p {
  font-weight: 400;
  font-size: 15px;
  text-align: center;
  color: #272727;
  max-width: 675px;
  margin: 0 auto;
}
.error-wrapper .home-btn {
  margin-top: 25px;
}
.error-wrapper .home-btn a {
  display: inline-block;
  background-color: #75DAB4;
  border-radius: 30px;
  font-weight: 600;
  font-size: 16px;
  color: #272727;
  text-align: center;
  text-transform: uppercase;
  min-width: 180px;
  padding: 15px 30px;
  border: 2px solid #75DAB4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.error-wrapper .home-btn a:hover {
  border: 2px solid #75DAB4;
  background-color: transparent;
}
.error-wrapper .home-btn a i {
  margin-right: 5px;
}

/*===========================
     18.FAQ page css 
===========================*/
@media (max-width: 767px) {
  .faqs-area {
    margin-top: 80px;
  }
}

.sidebar-tab {
  background-color: #FFFFFF;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.07);
  padding: 40px;
  margin-top: 40px;
}

.sidebar-tab:first-child {
  margin: 0;
}

.tabs a {
  display: block;
  text-align: center;
  font-weight: 600;
  font-size: 30px;
  color: #17161A;
}

.tab-link.active {
  color: #75DAB4;
}

.questions-form h4 {
  font-weight: 600;
  font-size: 30px;
  text-align: center;
  color: #17161A;
  margin-bottom: 30px;
}
.questions-form form input,
.questions-form form textarea {
  width: 100%;
  height: 50px;
  background-color: #F0F0F0;
  border: navajowhite;
  margin-bottom: 20px;
  padding: 0 10px;
  font-size: 14px;
  color: #272727;
}
.questions-form form input[type=submit],
.questions-form form textarea[type=submit] {
  background-color: #75DAB4;
  max-width: 160px;
  font-size: 18px;
  color: #ffffff;
  font-weight: 600;
  text-transform: capitalize;
  margin-bottom: 0;
  margin-top: 20px;
  border: 2px solid #75DAB4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.questions-form form input[type=submit]:hover,
.questions-form form textarea[type=submit]:hover {
  color: #000;
  background-color: transparent;
  border: 2px solid #75DAB4;
}
.questions-form form textarea {
  height: 145px;
  resize: none;
  padding: 10px;
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .faqs-tabs {
    margin-top: 50px;
  }
}

.faqs {
  margin-bottom: 80px;
}
.faqs h4 {
  position: relative;
  display: block;
  font-weight: 600;
  font-size: 25px;
  color: #17161A;
  margin-bottom: 50px;
}
.faqs h4:before {
  position: absolute;
  content: "";
  left: 0;
  bottom: -10px;
  width: 170px;
  border: 1px solid #EEEEEE;
}
.faqs:last-child {
  margin: 0;
}

.accordion-item {
  border: none;
  border-bottom: 2px solid #EEE;
}

.accordion-button {
  font-weight: 600;
  font-size: 18px;
  text-transform: capitalize;
  color: #17161A;
  padding-left: 0;
}

.accordion-button:not(.collapsed) {
  color: #17161A;
  background-color: transparent;
  box-shadow: none;
}

.accordion-button:focus {
  box-shadow: none;
  border: none;
}

.accordion-button::after {
  flex-shrink: 0;
  width: 1.25rem;
  height: 1.25rem;
  margin-left: auto;
  content: "\f64d";
  font-family: "bootstrap-icons";
  background: transparent;
  transition: transform 0.2s ease-in-out;
}

.accordion-button:not(.collapsed)::after {
  color: #75DAB4;
  content: "\f63b";
  font-family: "bootstrap-icons";
  background: transparent;
}

/*===========================
     19.Service page css 
===========================*/
@media (max-width: 767px) {
  .services-grid {
    margin: 80px 0;
  }
}

@media (max-width: 767px) {
  .service-details {
    margin: 80px 0;
  }
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .service-details-content {
    margin-bottom: 50px;
  }
}
.service-details-content > img {
  width: 100%;
}
.service-details-content h3 {
  font-weight: 600;
  font-size: 35px;
  color: #17161A;
  margin-top: 40px;
  margin-bottom: 30px;
}
@media (max-width: 767px) {
  .service-details-content h3 {
    font-size: 24px;
  }
}
.service-details-content h3 i {
  margin-right: 10px;
}
.service-details-content p {
  font-size: 15px;
  color: #272727;
  margin-bottom: 30px;
}
.service-details-content p:last-child {
  margin: 0;
}

.sidebar-widget {
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  padding: 35px 20px;
  margin-bottom: 40px;
}
.sidebar-widget:last-child {
  margin-bottom: 0;
}
.sidebar-widget h4 {
  font-weight: 700;
  font-size: 22px;
  display: inline-block;
  text-transform: uppercase;
  color: #17161A;
  margin-bottom: 20px;
  border-bottom: 2px solid #eee;
  padding-bottom: 10px;
}

.category {
  list-style: none;
}

.category li {
  margin-bottom: 15px;
}
.category li:last-child {
  margin: 0;
}
.category li a {
  font-weight: 500;
  font-size: 16px;
  color: #272727;
  position: relative;
  display: block;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.category li a i {
  position: absolute;
  right: 0;
}
.category li a:hover {
  color: #75DAB4;
}

.sidebar-banner {
  position: relative;
}
.sidebar-banner:before {
  position: absolute;
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  background-color: #17161A;
  opacity: 0.8;
  content: "";
}
.sidebar-banner img {
  width: 100%;
}

.banner-inner {
  position: absolute;
  left: 5%;
  top: 5%;
  width: 90%;
  height: 90%;
  padding: 100px 20px;
  background-color: #17161A;
  border-radius: 10px;
  background-image: url(../img/widget-content-bg.png);
  background-size: cover;
  background-position: center center;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .banner-inner {
    padding: 50px 20px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .banner-inner {
    padding: 20px;
  }
}
@media (max-width: 767px) {
  .banner-inner {
    padding: 60px 20px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .banner-inner {
    padding: 100px 20px;
  }
}
.banner-inner h3 {
  font-weight: 700;
  font-size: 41px;
  text-align: center;
  text-transform: uppercase;
  color: #FFFFFF;
  margin-bottom: 0;
}
@media (max-width: 767px) {
  .banner-inner h3 {
    font-size: 34px;
  }
}
.banner-inner h3 img.angle {
  position: relative;
  top: -10px;
  width: auto;
}
.banner-inner h3 span {
  color: #75DAB4;
  display: block;
}
.banner-inner a {
  position: absolute;
  bottom: 100px;
  left: 50%;
  font-weight: 700;
  font-size: 30px;
  display: block;
  color: #FFFFFF;
  width: 100%;
  text-align: center;
  transform: translateX(-50%);
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .banner-inner a {
    bottom: 50px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .banner-inner a {
    bottom: 20px;
  }
}
@media (max-width: 767px) {
  .banner-inner a {
    bottom: 60px;
  }
}
@media only screen and (min-width: 576px) and (max-width: 767px) {
  .banner-inner a {
    bottom: 100px;
  }
}

@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .service-items {
    margin-top: 80px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px) {
  .service-items {
    margin-top: 50px;
  }
}
@media (max-width: 767px) {
  .service-items {
    margin-top: 10px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .service-items .service-details-item {
    margin-top: 80px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .service-items .service-details-item .or-2 {
    order: 2;
  }
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .single-details {
    margin-bottom: 35px;
  }
}
.single-details h4 {
  font-weight: 600;
  font-size: 30px;
  color: #17161A;
  margin: 20px 0;
}
.single-details h4 span {
  font-weight: 700;
  font-size: 80px;
  opacity: 0.1;
  -webkit-text-stroke: 3px #17161A;
  -webkit-text-fill-color: transparent;
  margin-right: 10px;
  line-height: 1;
  display: inline-block;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), (max-width: 767px) {
  .single-details h4 span {
    font-size: 60px;
  }
}
.single-details p {
  font-size: 15px;
  color: #272727;
  text-align: justify;
}

.single-details-thumb img {
  width: 100%;
}

/*===========================
     20.Project page css 
===========================*/
@media (max-width: 767px) {
  .project-details {
    margin-top: 80px;
  }
}

.project-thumb {
  position: relative;
}
.project-thumb img {
  width: 100%;
}
.project-thumb .tag {
  position: absolute;
  bottom: 0;
}
.project-thumb .tag a {
  background-color: #75DAB4;
  font-weight: 500;
  font-size: 18px;
  display: inline-block;
  text-align: center;
  text-transform: capitalize;
  color: #272727;
  padding: 8px 20px;
  min-width: 140px;
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .project-details-content {
    margin-bottom: 40px;
  }
}
.project-details-content h3 {
  font-weight: 600;
  font-size: 35px;
  text-transform: capitalize;
  color: #17161A;
  margin: 30px 0 20px;
}
@media (max-width: 767px) {
  .project-details-content h3 {
    font-size: 30px;
  }
}
.project-details-content h3 p {
  text-align: justify;
  font-size: 15px;
}
.project-details-content .clinet-need {
  margin-top: 20px;
}
.project-details-content .clinet-need h4 {
  font-weight: 600;
  font-size: 30px;
  text-transform: capitalize;
  color: #17161A;
}
.project-details-content .clinet-need p {
  font-size: 15px;
  margin-bottom: 15px;
}
.project-details-content .clinet-need p:last-child {
  margin: 0;
}

.swiper.work-process-slide .arrow {
  position: absolute;
  right: 0;
  top: 50%;
  left: auto;
  transform: translateY(-50%) rotate(90deg);
  z-index: 1;
}
@media (max-width: 767px) {
  .swiper.work-process-slide .arrow {
    display: none;
  }
}
.swiper.work-process-slide .arrow .swiper-button-next-c,
.swiper.work-process-slide .arrow .swiper-button-prev-c {
  border: 1px solid #D3D3D3;
  box-sizing: border-box;
  height: 40px;
  width: 40px;
  text-align: center;
  line-height: 40px;
  color: #75DAB4;
  font-size: 18px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  overflow: hidden;
}
.swiper.work-process-slide .arrow .swiper-button-next-c:hover,
.swiper.work-process-slide .arrow .swiper-button-prev-c:hover {
  color: #fff;
  background-color: #75DAB4;
}
.swiper.work-process-slide .arrow .swiper-button-prev-c {
  position: absolute;
  right: 70px;
  top: 0;
  left: auto;
}

.working-process {
  margin-top: 20px;
}
.working-process h4 {
  font-weight: 600;
  font-size: 30px;
  text-transform: capitalize;
  color: #17161A;
  margin-bottom: 30px;
}
.working-process p {
  font-size: 15px;
  text-align: justify;
  margin-top: 30px;
}

.work-thumb {
  position: relative;
}
.work-thumb img {
  width: 85%;
}
@media (max-width: 767px) {
  .work-thumb img {
    width: 100%;
  }
}

.label {
  position: absolute;
  top: 0;
}
.label span {
  font-weight: 600;
  font-size: 22px;
  text-align: center;
  text-transform: capitalize;
  color: #FFFFFF;
  background-color: #17161A;
  padding: 5px 20px;
  display: inline-block;
}

.check-lunch h4 {
  font-weight: 600;
  font-size: 30px;
  text-transform: capitalize;
  color: #17161A;
  margin: 25px 0 20px;
}
.check-lunch p {
  text-align: justify;
  font-size: 15px;
}

.check {
  list-style: none;
}
@media (max-width: 767px) {
  .check {
    margin-bottom: 20px;
  }
}
.check li {
  margin-bottom: 15px;
  font-weight: 500;
  font-size: 18px;
  display: block;
  color: #17161A;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), (max-width: 767px) {
  .check li {
    font-size: 15px;
  }
}
.check li:last-child {
  margin: 0;
}
.check li i {
  margin-right: 10px;
}

.project-slider {
  position: relative;
  margin-top: 100px;
}
@media (max-width: 767px) {
  .project-slider {
    margin-top: 80px;
  }
}
.project-slider h4 {
  font-weight: 600;
  font-size: 35px;
  text-transform: capitalize;
  color: #17161A;
  margin-bottom: 50px;
}
@media (max-width: 767px) {
  .project-slider h4 {
    font-size: 30px;
  }
}
.project-slider .arrow {
  position: absolute;
  right: 0;
  top: 0;
  left: auto;
}
@media (max-width: 767px) {
  .project-slider .arrow {
    display: none;
  }
}
.project-slider .arrow .swiper-button-next-c,
.project-slider .arrow .swiper-button-prev-c {
  border: 1px solid #D3D3D3;
  box-sizing: border-box;
  border-radius: 50%;
  height: 40px;
  width: 40px;
  text-align: center;
  line-height: 40px;
  color: #75DAB4;
  font-size: 18px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
  overflow: hidden;
}
.project-slider .arrow .swiper-button-next-c:hover,
.project-slider .arrow .swiper-button-prev-c:hover {
  color: #fff;
  background-color: #75DAB4;
}
.project-slider .arrow .swiper-button-prev-c {
  position: absolute;
  right: 70px;
  top: 0;
  left: auto;
}

.client-box {
  margin-bottom: 20px;
}
.client-box:last-child {
  margin: 0;
}
.client-box span {
  position: relative;
  font-size: 15px;
  display: inline-block;
  color: #272727;
  margin-bottom: 5px;
  padding-left: 25px;
}
.client-box span:after {
  position: absolute;
  content: "";
  left: 0;
  top: 50%;
  transform: translateY(-50%);
  height: 16px;
  width: 16px;
  background-color: #75DAB4;
  border-radius: 50%;
}
.client-box span:before {
  position: absolute;
  content: "";
  left: 3px;
  top: 50%;
  transform: translateY(-50%);
  height: 10px;
  width: 10px;
  border: 1px solid rgba(255, 255, 255, 0.4);
  border-radius: 50%;
  z-index: 1;
}
.client-box h5 {
  font-weight: 600;
  font-size: 20px;
  color: #17161A;
  margin: 0;
}

.contact-info h3 {
  font-weight: 600;
  font-size: 35px;
  color: #17161A;
  margin-bottom: 20px;
}
@media (max-width: 767px) {
  .contact-info h3 {
    font-size: 30px;
  }
}
.contact-info p {
  font-size: 15px;
}

.cmpy-info {
  display: flex;
  width: 100%;
  align-items: center;
  margin-top: 30px;
}
.cmpy-info .icon {
  min-width: 60px;
}
.cmpy-info .icon i {
  height: 45px;
  width: 45px;
  line-height: 45px;
  font-size: 20px;
  text-align: center;
  background-color: rgba(23, 22, 26, 0.1);
  border-radius: 50%;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.cmpy-info .cnt h5 {
  font-size: 20px;
  font-weight: 600;
  color: #17161A;
  text-transform: uppercase;
  margin-bottom: 10px;
}
.cmpy-info .cnt p {
  font-size: 14px;
  font-weight: 500;
  color: #272727;
}
.cmpy-info .cnt a {
  font-size: 14px;
  font-weight: 500;
  color: #272727;
  display: block;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.cmpy-info .cnt a:hover {
  color: #75DAB4;
}
.cmpy-info:hover .icon i {
  color: #75dab4;
  background-color: rgba(117, 218, 180, 0.1);
}

/*===========================
     21.About page css 
===========================*/
@media (max-width: 767px) {
  .why-choose {
    margin: 80px 0;
  }
}

.why-choose-left {
  display: flex;
  width: 100%;
  align-items: start;
  position: relative;
}

@media (max-width: 767px) {
  .why-choose-right .sec-title.layout2 {
    margin-bottom: 30px;
  }
}

.choose-banner1 {
  min-width: 49%;
  margin-right: 5px;
}
.choose-banner1 img {
  width: 100%;
  border-radius: 5px;
}

.choose-banner2 {
  margin-top: 70px;
  min-width: 49%;
  margin-left: 5px;
}
.choose-banner2 img {
  width: 100%;
  border-radius: 5px;
}
.choose-banner2 img:first-child {
  margin-bottom: 10px;
}

.years {
  background-color: #17161A;
  border-radius: 5px;
  position: absolute;
  top: 0;
  right: 0;
  text-align: center;
  padding: 20px;
}
.years h5 {
  font-weight: 700;
  font-size: 28px;
  text-align: center;
  color: #75DAB4;
  margin-bottom: 5px;
}
.years span {
  font-weight: 500;
  font-size: 18px;
  text-transform: uppercase;
  color: #FFFFFF;
}

.counter-boxes {
  margin-bottom: 40px;
  display: flex;
  width: 100%;
  align-items: center;
  justify-content: space-between;
}
@media (max-width: 767px) {
  .counter-boxes {
    align-items: flex-start;
  }
}
.counter-boxes .count-box {
  min-width: 33.33%;
  margin-right: 10px;
}
.counter-boxes .count-box:last-child {
  margin-right: 0;
}
@media (max-width: 767px) {
  .counter-boxes .count-box {
    margin-right: 0;
  }
}
.counter-boxes .count-box span {
  font-weight: 700;
  font-size: 35px;
  color: #75DAB4;
  display: inline-block;
  margin-bottom: 5px;
}
.counter-boxes .count-box sup {
  top: -10px;
  font-weight: 700;
  font-size: 35px;
  color: #75DAB4;
  display: inline-block;
  margin-bottom: 5px;
}
.counter-boxes .count-box h5 {
  font-weight: 500;
  font-size: 18px;
  color: #272727;
  margin: 0;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .counter-boxes .count-box h5 {
    font-size: 17px;
  }
}

.buttons-group {
  margin-top: 40px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
@media (max-width: 767px) {
  .buttons-group {
    display: block;
    text-align: center;
  }
}
.buttons-group span {
  background-color: #75DAB4;
  border: 1px solid #75DAB4;
  box-sizing: border-box;
  border-radius: 5px;
  font-weight: 600;
  font-size: 15px;
  display: inline-block;
  text-align: center;
  color: #0F1012;
  padding: 12px 30px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media (max-width: 767px) {
  .buttons-group span {
    margin-top: 15px;
    margin-left: 10px;
  }
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .buttons-group span {
    padding: 15px;
  }
}
.buttons-group span:hover {
  color: #75DAB4;
  border: 1px solid #75DAB4;
  background-color: transparent;
}

@media (max-width: 767px) {
  .history-area {
    margin: 80px 0;
  }
}

.single-history {
  position: relative;
  display: flex;
  width: 100%;
  margin-bottom: 60px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .single-history {
    display: block;
  }
}
@media (max-width: 767px) {
  .single-history {
    margin-bottom: 40px;
  }
}
.single-history:before {
  position: absolute;
  left: 50%;
  top: 0;
  height: 100%;
  width: 5px;
  background-color: #272727;
  content: "";
  border-radius: 10px;
  transform: translateX(-50%);
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .single-history:before {
    display: none;
  }
}
.single-history:last-child {
  margin-bottom: 0;
}

.history {
  position: relative;
  min-width: 50%;
}
.history:first-child {
  padding-right: 100px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .history:first-child {
    padding-right: 40px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history:first-child {
    padding: 0;
  }
}
.history:first-child .circle {
  position: absolute;
  right: -7px;
  transform: rotate(180deg);
  bottom: 60px;
}
.history:first-child .history-cnt-inner {
  margin-right: 60px;
  margin-left: 0;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history:first-child .history-cnt-inner {
    margin-right: 0;
    margin-bottom: 20px;
  }
}
.history:first-child .history-cnt-inner span {
  position: absolute;
  right: -105px;
  left: auto;
  top: 85px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history:first-child .history-cnt-inner span {
    position: static;
  }
}
.history:last-child {
  padding-left: 100px;
}
@media only screen and (min-width: 1200px) and (max-width: 1399px) {
  .history:last-child {
    padding-left: 40px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history:last-child {
    padding: 0;
  }
}
.history:last-child .circle {
  position: absolute;
  left: -7px;
  top: 60px;
}
.history:last-child .history-cnt-inner {
  margin-left: 60px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history:last-child .history-cnt-inner {
    margin-left: 0;
  }
}
.history .history-thumb {
  position: relative;
  z-index: 1;
}
.history .history-thumb img {
  width: 100%;
}

.circle {
  position: relative;
  height: 14px;
  width: 14px;
  background: #75DAB4;
  border-radius: 50%;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .circle {
    display: none;
  }
}
.circle:before {
  position: absolute;
  content: "";
  left: -3px;
  top: -3px;
  height: 20px;
  width: 20px;
  border: 1px solid #75DAB4;
  border-radius: 50%;
  animation-name: rotateme;
  animation-duration: 5s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  transition: all 0.2s cubic-bezier(0.98, 0.57, 1, 1) 0s;
}
.circle:after {
  position: absolute;
  content: "";
  left: -6px;
  top: -6px;
  height: 26px;
  width: 26px;
  border: 1px solid #75DAB4;
  border-radius: 50%;
  animation-name: rotateme;
  animation-duration: 5s;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  transition: all 0.2s cubic-bezier(0.98, 0.57, 1, 1) 0s;
}
.circle .inner {
  width: 70px;
  border: 1.5px dashed #75DAB4;
  position: relative;
  top: 5.5px;
  left: 15px;
  border-radius: 10px;
}

.history-cnt .history-cnt-inner {
  position: relative;
  margin-left: 60px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history-cnt .history-cnt-inner {
    margin-left: 0;
  }
}
.history-cnt .history-cnt-inner h4 {
  font-weight: 600;
  font-size: 30px;
  color: #17161A;
  text-transform: capitalize;
  margin-bottom: 15px;
}
@media (max-width: 767px) {
  .history-cnt .history-cnt-inner h4 {
    font-size: 24px;
  }
}
.history-cnt .history-cnt-inner span {
  font-weight: 700;
  font-size: 60px;
  color: #17161A;
  opacity: 0.1;
  transform: rotate(-90deg);
  position: absolute;
  left: -105px;
  top: 85px;
}
@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .history-cnt .history-cnt-inner span {
    position: static;
    transform: none;
  }
}
@media (max-width: 767px) {
  .history-cnt .history-cnt-inner span {
    font-size: 40px;
  }
}
.history-cnt .history-cnt-inner p {
  font-size: 15px;
  text-align: justify;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .history-cnt .history-cnt-inner p {
    font-size: 14px;
  }
}

/*===========================
     22.Blog page css 
===========================*/
@media (max-width: 767px) {
  .blog-grid {
    margin-top: 80px;
  }
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .blog-item-grid {
    margin-top: 50px;
  }
}

.widget-search {
  position: relative;
}
.widget-search form input {
  background-color: #F0F0F0;
  border-radius: 3px;
  border: none;
  height: 50px;
  width: 100%;
  padding: 0 10px;
}
.widget-search form input[type=text] {
  padding-right: 75px;
}
.widget-search form button {
  position: absolute;
  border: none;
  font-size: 20px;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
  color: #17161A;
  background: #75DAB4;
  border-radius: 0px 3px 3px 0px;
  height: 50px;
  width: 70px;
}

.recent-post {
  display: flex;
  align-items: center;
  margin-bottom: 30px;
}
.recent-post:last-child {
  margin-bottom: 0;
}
.recent-post span {
  font-weight: 500;
  font-size: 16px;
  color: #5F6062;
  display: inline-block;
  margin-bottom: 5px;
}
.recent-post h5 {
  margin: 0;
}
.recent-post h5 a {
  font-weight: 600;
  font-size: 18px;
  text-transform: capitalize;
  color: #2E2D31;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
@media only screen and (min-width: 992px) and (max-width: 1199px) {
  .recent-post h5 a {
    font-size: 15px;
  }
}
.recent-post .recent-thumb {
  min-width: 120px;
  overflow: hidden;
}
.recent-post .recent-thumb a img {
  width: 100px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.recent-post:hover .recent-thumb a img {
  transform: scale(1.1);
}
.recent-post:hover h5 a {
  color: #75DAB4;
}

.tag-list {
  list-style: none;
}
.tag-list li {
  display: inline-block;
}
.tag-list li a {
  display: inline-block;
  border: 1px solid rgba(23, 22, 26, 0.2);
  box-sizing: border-box;
  border-radius: 2px;
  padding: 8px 15px;
  margin: 10px;
  color: #A0A0A0;
  font-size: 12px;
  font-weight: 500;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.tag-list li a:hover {
  color: #75DAB4;
  border: 1px solid #75DAB4;
}

.load-more {
  text-align: center;
  margin-top: 50px;
}

.paginations li {
  display: inline-block;
  margin: 0 2.5px;
}
.paginations li.active a {
  color: #fff;
  border: 1px solid #75DAB4;
  background-color: #75DAB4;
}
.paginations li a {
  border: 1px solid rgba(23, 22, 26, 0.2);
  box-sizing: border-box;
  display: inline-block;
  height: 40px;
  width: 40px;
  line-height: 40px;
  text-align: center;
  font-size: 16px;
  font-weight: 600;
  font-family: "Saira", sans-serif;
  color: #D3D3D3;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.paginations li a:hover {
  color: #fff;
  background-color: #75DAB4;
}

@media (max-width: 767px) {
  .blog-standard {
    margin-top: 80px;
  }
  .blog-standard .or-2 {
    order: 2;
  }
  .blog-standard .or-1 {
    order: 1;
  }
}

@media (max-width: 767px) {
  .blog-standard-details {
    margin-top: 40px;
  }
}

.single-blog.layout3 {
  display: flex;
  width: 100%;
}
@media (max-width: 767px) {
  .single-blog.layout3 {
    display: block;
  }
}
.single-blog.layout3 .blog-thumb {
  min-width: 49%;
}
.single-blog.layout3 .blog-thumb a img {
  border-radius: 10px;
}
.single-blog.layout3 .blog-inner {
  min-width: 50%;
}
.single-blog.layout3 .blog-inner h4 {
  margin-bottom: 10px;
}
.single-blog.layout3 .blog-inner h4 a {
  font-size: 26px;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .single-blog.layout3 .blog-inner h4 a {
    font-size: 18px;
  }
}
.single-blog.layout3 .blog-inner p {
  font-size: 16px;
}
@media only screen and (min-width: 992px) and (max-width: 1199px), only screen and (min-width: 768px) and (max-width: 991px) {
  .single-blog.layout3 .blog-inner p {
    font-size: 14px;
  }
}
.single-blog.layout3:hover .blog-thumb a img {
  border-radius: 10px;
  transform: scale(1.1) skewY(0);
}

.single-blog.layout4 {
  margin-top: 50px;
}
.single-blog.layout4 .blog-inner h4 {
  margin-bottom: 10px;
}
.single-blog.layout4 .blog-inner h4 a {
  font-size: 26px;
}
@media (max-width: 767px) {
  .single-blog.layout4 .blog-inner h4 a {
    font-size: 20px;
  }
}
.single-blog.layout4:hover .blog-thumb a img {
  border-radius: 10px;
  transform: scale(1.1) skewY(0);
}

@media (max-width: 767px) {
  .blog-details-area {
    margin-top: 80px;
  }
}

@media only screen and (min-width: 768px) and (max-width: 991px), (max-width: 767px) {
  .blog-details-content {
    margin-bottom: 50px;
  }
}
.blog-details-content h3 {
  font-weight: 600;
  font-size: 27px;
  text-transform: capitalize;
  color: #17161A;
  margin-bottom: 20px;
}
@media (max-width: 767px) {
  .blog-details-content h3 {
    font-size: 22px;
  }
}
.blog-details-content h4 {
  font-weight: 600;
  font-size: 27px;
  text-transform: capitalize;
  color: #17161A;
  margin-bottom: 20px;
}
@media (max-width: 767px) {
  .blog-details-content h4 {
    font-size: 22px;
  }
}
.blog-details-content p {
  font-size: 15px;
  color: #272727;
  text-align: justify;
}

.author-date {
  display: flex;
  justify-content: space-between;
  margin-bottom: 15px;
}
.author-date.layout2 {
  margin-bottom: 30px;
}
.author-date a {
  font-weight: 500;
  font-size: 17px;
  text-transform: capitalize;
  color: #5F6062;
  display: inline-block;
}

.details-thumb {
  margin-bottom: 30px;
}
.details-thumb img {
  width: 100%;
}

.blog-gallery {
  display: flex;
  width: 100%;
  margin: 30px 0;
}
.blog-gallery img {
  width: 100%;
}
.blog-gallery .b-gallery {
  width: 50%;
}
.blog-gallery .b-gallery:first-child {
  margin-right: 10px;
}
.blog-gallery .b-gallery:last-child {
  margin-left: 10px;
}

.special {
  margin-bottom: 10px;
}
.special p span {
  font-size: 75px;
  color: #272727;
  float: left;
  line-height: 55px;
}

.blog-quote {
  position: relative;
}
.blog-quote p {
  font-size: 25px;
  color: #272727;
  font-style: italic;
  margin: 30px 0;
  padding-left: 100px;
}
@media (max-width: 767px) {
  .blog-quote p {
    font-size: 15px;
  }
}
.blog-quote i {
  font-size: 70px;
  color: rgba(39, 39, 39, 0.1);
  position: absolute;
  left: 0;
  top: 50%;
  transform: translateY(-50%);
}

.tag-share {
  display: flex;
  width: 100%;
  justify-content: space-between;
  padding: 50px 0;
  border-bottom: 1px solid #EEEEEE;
}
@media (max-width: 767px) {
  .tag-share {
    display: block;
  }
}

.line-tag {
  min-width: 50%;
}
@media (max-width: 767px) {
  .line-tag {
    margin-bottom: 20px;
  }
}
.line-tag span {
  font-weight: 600;
  font-size: 22px;
  color: #17161A;
  display: inline-block;
  margin-right: 5px;
}
.line-tag a {
  display: inline-block;
  font-size: 17px;
  font-weight: 500;
  color: #A4A4A4;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.line-tag a:hover {
  color: #75DAB4;
}

.share-blog {
  min-width: 50%;
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  padding: 10px 30px;
  text-align: center;
}
.share-blog span {
  font-weight: 600;
  font-size: 22px;
  display: inline-block;
  color: #17161A;
  margin-right: 5px;
}

.social-share-blog {
  display: inline-block;
  list-style: none;
}
.social-share-blog li {
  display: inline-block;
  margin: 0 10px;
}
.social-share-blog li a {
  display: inline-block;
  color: #909090;
  font-size: 16px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.social-share-blog li a:hover {
  color: #75DAB4;
}

.comments {
  margin-top: 50px;
}
.comments h3 {
  font-weight: 600;
  font-size: 35px;
  text-transform: capitalize;
  color: #111111;
  border-bottom: 1px solid #EEEEEE;
  padding-bottom: 10px;
  margin-bottom: 40px;
}

.single-comment {
  margin-bottom: 50px;
}
.single-comment:last-child {
  margin: 0;
}

.author-post {
  position: relative;
  display: flex;
  align-items: center;
  width: 100%;
  margin-bottom: 15px;
}

.author-thumb {
  min-width: 90px;
}
.author-thumb img {
  height: 70px;
  width: 70px;
}

.author-info h5 {
  font-weight: 600;
  font-size: 20px;
  text-transform: uppercase;
  color: #111111;
  margin-bottom: 5px;
}
.author-info span {
  font-weight: 500;
  font-size: 15px;
  letter-spacing: 1px;
  text-transform: uppercase;
  color: #A4A4A4;
}

.reply {
  position: absolute;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}
@media (max-width: 767px) {
  .reply {
    display: none;
  }
}
.reply a {
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  font-weight: 500;
  font-size: 16px;
  text-transform: uppercase;
  color: #111111;
  padding: 5px 10px;
  -webkit-transition: all 0.5s ease-out 0s;
  -moz-transition: all 0.5s ease-out 0s;
  -ms-transition: all 0.5s ease-out 0s;
  -o-transition: all 0.5s ease-out 0s;
  transition: all 0.5s ease-out 0s;
}
.reply a i {
  margin-right: 5px;
}
.reply a:hover {
  color: #75DAB4;
  border: 1px solid #75DAB4;
}

.comment-form {
  margin-top: 70px;
}
.comment-form h5 {
  font-weight: 600;
  font-size: 35px;
  text-transform: capitalize;
  color: #00152B;
  border-bottom: 1px solid #eee;
  padding-bottom: 10px;
  margin-bottom: 40px;
}
.comment-form form label {
  font-weight: 500;
  font-size: 15px;
  color: #17161A;
  width: 100%;
}
.comment-form form label input {
  background-color: #FFFFFF;
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  width: 100%;
  height: 50px;
  padding: 0 20px;
  margin-bottom: 30px;
  margin-top: 5px;
}
.comment-form form label textarea {
  background-color: #FFFFFF;
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  width: 100%;
  height: 250px;
  padding: 20px;
  resize: none;
  margin-bottom: 30px;
  margin-top: 5px;
}
.comment-form form input[type=submit] {
  font-weight: 600;
  font-size: 16px;
  text-align: center;
  color: #FFFFFF;
  background-color: #17161A;
  border: 1px solid #F0F0F0;
  box-sizing: border-box;
  height: 50px;
  min-width: 200px;
  border-radius: 10px;
  padding: 10px 30px;
}

/*-----------------------------------------------------------------------------------
    Custom
-----------------------------------------------------------------------------------*/
.single-partner {
  filter: grayscale(1);
}

/*# sourceMappingURL=style.cs.map */
