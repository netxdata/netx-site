import React from 'react'
import { copy } from '../../../data/data'
import { identity } from '../../../data/data'
import MailchimpFullForm from '../../common/mailchimp/MailchimpFullForm'

function ContactWrapper() {
  return (
    <>
     <section className="contact-area sec-mar">
        <div className="container">
          <div className="row">
            <div className="col-md-6 col-lg-5">
              <div className="contact-left">
                <div className="sec-title layout2">
                  <span>{copy.contact.cta1}</span>
                  <h2>{copy.contact.copy1}</h2>
                </div>
                {/* <ul className="social-follow">
                  <li><a rel="noopener noreferrer" href="https://www.facebook.com/"><i className="fab fa-facebook-f" /></a></li>
                  <li><a rel="noopener noreferrer" href="https://www.twitter.com/"><i className="fab fa-twitter" /></a></li>
                  <li><a rel="noopener noreferrer" href="https://www.pinterest.com/"><i className="fab fa-pinterest-p" /></a></li>
                  <li><a rel="noopener noreferrer" href="https://www.instagram.com/"><i className="fab fa-instagram" /></a></li>
                </ul> */}
                <div className="informations">
                  <div className="single-info">
                    <div className="icon">
                      <i className="fas fa-map-marker-alt" />
                    </div>
                    <div className="info">
                      <h3>{copy.contact.copy2}</h3>
                      <p>{identity.address}</p>
                    </div>
                  </div>
                  {/* <div className="single-info">
                    <div className="icon">
                      <i className="fas fa-phone-alt" />
                    </div>
                    <div className="info">
                      <h3>{copy.contact.copy3}</h3>
                      <a href="tel:05661111985">+880 566 1111 985</a>
                      <a href="tel:06571111576">+880 657 1111 576</a>
                    </div>
                  </div> */}
                  <div className="single-info">
                    <div className="icon">
                      <i className="far fa-envelope" />
                    </div>
                    <div className="info">
                      <h3>{copy.contact.copy4}</h3>
                      <a href={`mailto:${identity.mail1}`}>{identity.mail1}</a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-md-6 col-lg-7">
              <div className="mapouter">
                <div className="gmap_canvas">
                  <iframe src={copy.contact.map} />
                </div>
              </div>
            </div>
          </div>
          <div className="getin-touch">
            <div className="row">
              <div className="col-md-6 col-lg-7">
                <div className="contact-form wow animate fadeInUp" data-wow-delay="200ms" data-wow-duration="1500ms">
                  <h3>{copy.contact.copy5}</h3>
                  {/* <form action="#" method="post">
                    <div className="row">
                      <div className="col-12">
                        <input type="text" name="name" placeholder="Enter your name" />
                      </div>
                      <div className="col-md-6">
                        <input type="email" name="email" placeholder="Enter your email" />
                      </div>
                      <div className="col-md-6">
                        <input type="text" name="subject" placeholder="Subject" />
                      </div>
                      <div className="col-12">
                        <textarea name="message" cols={30} rows={10} placeholder="Your message" defaultValue={""} />
                        <input type="submit" defaultValue="Send Message" />
                      </div>
                    </div>
                  </form> */}
                  <MailchimpFullForm />
                </div>
              </div>
              <div className="col-md-6 col-lg-5 wow animate fadeInUp" data-wow-delay="300ms" data-wow-duration="1500ms">
                <div className="call-banner">
                  <img src={process.env.PUBLIC_URL + "/img/call-center.png"} alt="images" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>   
    </>
  )
}

export default ContactWrapper