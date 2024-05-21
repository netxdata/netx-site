import React from "react";
import Breadcrumb from "../../common/Breadcrumb";
import SubscribArea from "../../common/SubscribArea";
import ContactWrapper from "./ContactWrapper";
import AnimateLine from "../../common/AnimateLine";
import { copy } from "../../../data/data";

function Contact() {
  return (
    <>
      <div className="creasoft-wrap">
        <AnimateLine />
        <Breadcrumb pageTitle={copy.contact.cta1} pageName={copy.contact.cta1} />
        <ContactWrapper />
        {/* <SubscribArea /> */}
      </div>
    </>
  );
}

export default Contact;
