import React from 'react'
import { copy } from '../../../data/data'

function HistoryArea() {
  const aboutUsComponents = copy.aboutus
  return (
    <>
     <section className="history-area sec-mar">
        <div className="container">
          <div className="title-wrap">
            <div className="sec-title">
              <span>{copy.aboutus.title}</span>
              <h2>{copy.aboutus.subtitle}</h2>
            </div>
          </div>
          
          <div className="single-history">
            <div className="history wow animate fadeInLeft" data-wow-delay="200ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-thumb">
                <img src={process.env.PUBLIC_URL + copy.aboutuscomponent[0].img} alt="history-img" />
              </div>
            </div>
            <div className="history wow animate fadeInRight" data-wow-delay="200ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-cnt">
                <div className="history-cnt-inner">
                  <span>{copy.aboutuscomponent[0].subtitle}</span>
                  <h4>{copy.aboutuscomponent[0].title}</h4>
                  <p>{copy.aboutuscomponent[0].description}</p>
                </div>
              </div>
            </div>
          </div>
          <div className="single-history">
            <div className="history wow animate fadeInLeft" data-wow-delay="300ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-cnt">
                <div className="history-cnt-inner">
                  <span>{copy.aboutuscomponent[1].subtitle}</span>
                  <h4>{copy.aboutuscomponent[1].title}</h4>
                  <p>{copy.aboutuscomponent[1].description}</p>
                </div>
              </div>
            </div>
            <div className="history wow animate fadeInRight" data-wow-delay="300ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-thumb">
                <img src={process.env.PUBLIC_URL + copy.aboutuscomponent[1].img} alt="history-img" />
              </div>
            </div>
          </div>   

          {/*<div className="single-history">
            <div className="history wow animate fadeInLeft" data-wow-delay="400ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-thumb">
                <img src={process.env.PUBLIC_URL + '/img/timeline-3.jpg'} alt="history-img" />
              </div>
            </div>
            <div className="history wow animate fadeInRight" data-wow-delay="400ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-cnt">
                <div className="history-cnt-inner">
                  <span>2022</span>
                  <h4>We Are Success And Win</h4>
                  <p>Integer purus odio, placerat nec rhoncus in, ullamcorper nec aptent taciti sociosqu ad litora torquent per conubia nostra,
                    himenaeos. Praesent nec neque at dolor venenatis thoseaol Donec lacinia placerat felis non aliquam.Mauris nec justo ag euismod sit amet non ipsum. Praesent commodo at massa vitae enim velit. Ut ut posuere orci, id dapibus odio. himenaeos. Praesent nec neque at dolor venenatis thoseaol Donec lacinia placerat felis non aliquam.Mauris nec justo ag euismod sit amet non ipsum. Praesent commodo at massa</p>
                </div>
              </div>
            </div>
          </div>
          <div className="single-history">
            <div className="history wow animate fadeInLeft" data-wow-delay="500ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-cnt">
                <div className="history-cnt-inner">
                  <span>2023</span>
                  <h4>Many Award Win</h4>
                  <p>Integer purus odio, placerat nec rhoncus in, ullamcorper nec aptent taciti sociosqu ad litora torquent per conubia nostra,
                    himenaeos. Praesent nec neque at dolor venenatis thoseaol Donec lacinia placerat felis non aliquam.Mauris nec justo ag euismod sit amet non ipsum. Praesent commodo at massa vitae enim velit. Ut ut posuere orci, id dapibus odio. himenaeos. Praesent nec neque at dolor venenatis thoseaol Donec lacinia placerat felis non aliquam.Mauris nec justo ag euismod sit amet non ipsum. Praesent commodo at massa</p>
                </div>
              </div>
            </div>
            <div className="history wow animate fadeInRight" data-wow-delay="500ms" data-wow-duration="1500ms">
              <div className="circle">
                <div className="inner" />
              </div>
              <div className="history-thumb">
                <img src={process.env.PUBLIC_URL + '/img/timeline-4.jpg'} alt="history-img" />
              </div>
            </div>
          </div> */}

        </div>
      </section>   
    </>
  )
}

export default HistoryArea