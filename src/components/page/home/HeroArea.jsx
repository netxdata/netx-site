import React from 'react'
import { Link } from 'react-router-dom'
import { copy, identity } from '../../../data/data'

function HeroArea() {
  const scrollTop =()=>window.scrollTo({top:0,behavior:"smooth"})
  const fullName = identity.name.split(' ');
  const name = fullName[0];
  const surname = fullName[1];

  return (
    <>
     <section className="hero-area">
        <div className="ken-burns-slideshow">
          <img src={process.env.PUBLIC_URL + "/img/hero-banner.jpg"} alt="HeroBanner" />
        </div>
        {/* <div className="verticale-social">
          <ul className="vertical-media">
            <li><a href="https://www.facebook.com/">Facebook</a></li>
            <li><a href="https://www.instagram.com/">Instagram</a></li>
            <li><a href="https://www.linkedin.com/">Linkedin</a></li>
          </ul>
        </div> */}
        <div className="hero-wrapper">
          <div className="container">
            <div className="row">
              <div className="col-lg-6">
                <div className="hero-content">
                  <h1>{name}<span>{surname}</span></h1>
                  <p>{identity.description_short}</p>
                  <div className="buttons">
                    <div className="cmn-btn">
                      <div className="line-1" />
                      <div className="line-2" />
                      <Link to={`${process.env.PUBLIC_URL}/contact`} onClick={scrollTop}>{copy.banner.call_to_action}</Link>
                    </div>
                    <div className="cmn-btn layout-two">
                      <div className="line-1" />
                      <div className="line-2" />
                      <Link to={`${process.env.PUBLIC_URL}/service`} onClick={scrollTop}>{copy.banner.cta_2}</Link>
                    </div>
                  </div>
                </div>
              </div>
              <div className="col-lg-6" />
            </div>
          </div>
        </div>
      </section>   
    </>
  )
}

export default HeroArea