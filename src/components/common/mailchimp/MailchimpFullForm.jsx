import React from "react";
import { copy } from "../../../data/data";

function MailchimpFullForm() {
  return (
    <form
      action="https://netxdata.us22.list-manage.com/subscribe/post?u=cdea3b05c8eb225aab7ce8071&id=9fe854216f&v_id=17&f_id=00c3c4e1f0"
      method="post"
      id="mc-embedded-subscribe-form"
      name="mc-embedded-subscribe-form"
      className="validate"
      target="_self"
      noValidate
    >
      <div id="mc_embed_signup_scroll">
        {/* <h2>Iscriviti</h2> */}
        {/* <div className="indicates-required">
          <span className="asterisk">*</span> indica requisiti obbligatori
        </div> */}
        <div className="mc-field-group">
          {/* <label htmlFor="mce-FNAME">Nome </label> */}
          <input type="text" name="FNAME" className="text" id="mce-FNAME" placeholder={copy.contact.form.copy1}/>
        </div>
        <div className="mc-field-group">
          {/* <label htmlFor="mce-EMAIL">
            Indirizzo email <span className="asterisk">*</span>
          </label> */}
          <input
            type="email"
            name="EMAIL"
            className="required email"
            id="mce-EMAIL"
            placeholder={copy.contact.form.copy2}
            required
          />
        </div>
        <div className="mc-field-group">
          {/* <label htmlFor="mce-PHONE">
            Numero di telefono <span className="asterisk">*</span>
          </label> */}
          <input type="text" name="PHONE" className="REQ_CSS" id="mce-PHONE" placeholder={copy.contact.form.copy3}/>
        </div>
        <div
          id="mergeRow-gdpr"
          className="mergeRow gdpr-mergeRow content__gdprBlock mc-field-group"
        >
          <div className="content__gdpr">
            {/* <label>Marketing Permission</label> */}
            <p>
            {copy.contact.form.copy4}
            </p>
            <fieldset
              className="mc_fieldset gdprRequired mc-field-group"
              name="interestgroup_field"
            >
              <label className="checkbox subfield" htmlFor="gdpr_188">
                <div className="mc-checkbox">
                  <input
                    type="checkbox"
                    id="gdpr_188"
                    name="gdpr[188]"
                    className="gdpr"
                    value="Y"
                  />
                  {copy.contact.form.copy5}
                </div>
              </label>
              <label className="checkbox subfield" htmlFor="gdpr_189">
                <div className="mc-checkbox">
                  <input
                    type="checkbox"
                    id="gdpr_189"
                    name="gdpr[189]"
                    className="gdpr"
                    value="Y"
                  />
                  {copy.contact.form.copy6}  
                </div>
              </label>
            </fieldset>
            <p>
            {copy.contact.form.copy7}
            </p>
          </div>
          <div className="content__gdprLegal">
            <p>
            {copy.contact.form.copy8}{" "}
            </p>
            <p>
              <a href="https://mailchimp.com/legal/terms">{copy.contact.form.copy9}</a>{copy.contact.form.copy10}
            </p>
          </div>
        </div>
        <div id="mce-responses" className="clear foot">
          <div
            className="response"
            id="mce-error-response"
            style={{ display: "none" }}
          ></div>
          <div
            className="response"
            id="mce-success-response"
            style={{ display: "none" }}
          ></div>
        </div>
        <div
          aria-hidden="true"
          style={{ position: "absolute", left: "-5000px" }}
        >
          {/* real people should not fill this in and expect good things - do not remove this or risk form bot signups */}
          <input
            type="text"
            name="b_cdea3b05c8eb225aab7ce8071_9fe854216f"
            tabIndex="-1"
          />
        </div>
        <div className="optionalParent">
          <div className="clear foot">
            <input
              type="submit"
              name="subscribe"
              id="mc-embedded-subscribe"
              className="button"
              value="Subscribe"
            />
          </div>
        </div>
      </div>
    </form>
  );
}

export default MailchimpFullForm;
