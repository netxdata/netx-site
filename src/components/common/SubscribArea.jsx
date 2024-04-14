import React from "react";
import { copy } from "../../data/data";
import MailchimpLittleForm from "./mailchimp/MailchimpLittleForm";

function SubscribArea() {
  return (
    <>
      <section className="subscribe-newsletter sec-mar-top">
        <div className="container">
          <div className="news-letter-content">
            <div className="row align-items-center">
              <div
                className="col-lg-6 wow animate fadeInLeft"
                data-wow-delay="200ms"
                data-wow-duration="1500ms"
              >
                <div className="subscribe-cnt">
                  <span>{copy.footersubscribe.title}</span>
                  <h3>{copy.footersubscribe.subtitle}</h3>
                  <strong>{copy.footersubscribe.subsubtitle}</strong>
                </div>
              </div>
              <div
                className="col-lg-6 wow animate fadeInRight"
                data-wow-delay="200ms"
                data-wow-duration="1500ms"
              >
                <div className="subscribe-form">
                  <MailchimpLittleForm />
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
    </>
  );
}

export default SubscribArea;
