import React from "react";
import { copy } from "../../../data/data";

function MailchimpFullForm() {
  return (
    <form 
      action="https://netxdata.us22.list-manage.com/subscribe/post?u=cdea3b05c8eb225aab7ce8071&amp;id=9fe854216f&amp;f_id=00c3c4e1f0" 
      method="post" 
      id="mc-embedded-subscribe-form" 
      name="mc-embedded-subscribe-form" 
      className="validate" 
      target="_self" 
    >
      <div id="mc_embed_signup_scroll">
          <div className="mc-field-group"><input type="email" name="EMAIL" className="required email" id="mce-EMAIL" placeholder={copy.contact.form.copy2} required /></div>
          <div className="mc-field-group"><input type="text" name="FNAME" className=" text" id="mce-FNAME" placeholder={copy.contact.form.copy1} /></div>
          <div className="mc-field-group"><textarea className=" text" id="mce-MMERGE4" name="MMERGE4" placeholder={copy.contact.form.copy3} rows="4" cols="50"></textarea></div>
          <div id="mce-responses" className="clear foot">
              <div className="response" id="mce-error-response" style={{ display: 'none' }}></div>
              <div className="response" id="mce-success-response" style={{ display: 'none' }}></div>
          </div>
          <div aria-hidden="true" style={{ position: 'absolute', left: '-5000px' }}>
              {/* real people should not fill this in and expect good things - do not remove this or risk form bot signups */}
              <input type="text" name="b_cdea3b05c8eb225aab7ce8071_9fe854216f" tabIndex="-1" defaultValue="" />
          </div>
          <div className="optionalParent">
              <div className="clear foot">
                  <input type="submit" name="subscribe" id="mc-embedded-subscribe" className="button" value="Subscribe" />
              </div>
          </div>
      </div>
    </form>

  );
}

export default MailchimpFullForm;
