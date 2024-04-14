import React from "react";
import { copy } from "../../../data/data";

function MailchimpFullForm() {
  return (
    <form
      onScroll={(e) => e.preventDefault()}
      action="https://netxdata.us22.list-manage.com/subscribe/post?u=cdea3b05c8eb225aab7ce8071&amp;id=9fe854216f&amp;f_id=00c3c4e1f0"
      method="post"
      id="mc-embedded-subscribe-form"
      name="mc-embedded-subscribe-form"
      className="validate"
      target="_blank"
    >
      <input
        type="email"
        name="EMAIL"
        className="required email"
        id="mce-EMAIL"
        required
        placeholder={copy.footersubscribe.body}
      />
      <input
        type="submit"
        name="subscribe"
        id="mc-embedded-subscribe"
        className="button"
        value="Subscribe"
      />
    </form>
  );
}

export default MailchimpFullForm;
