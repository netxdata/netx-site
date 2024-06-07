import React from 'react';
import Iubenda from '../iubenda/Iubenda';

const GdprMailchimpSection = () => {
  return (
    <div
      id="mergeRow-gdpr"
      className="mergeRow gdpr-mergeRow content__gdprBlock mc-field-group"
    >
      <div className="content__gdpr">

        {/*<label>Privacy Policy</label>
        <p>
          Seleziona tutti i modi in cui desideri ricevere notizie da Netx:
        </p> */}

        <fieldset
          className="mc_fieldset gdprRequired mc-field-group"
          name="interestgroup_field"
        >
          <label className="checkbox subfield" htmlFor="gdpr188">
            <input
              type="checkbox"
              id="gdpr_188"
              name="gdpr[188]"
              className="gdpr"
              value="Y"
            />
          </label>
          <div className="content__gdpr__spunta">
            <span>Spuntando questa casella dichiaro di aver preso visione dell' </span><Iubenda /><span> resa ai sensi dell’Art. 13 Regolamento Europeo 679/2016,   e di rilasciare il consenso al trattamento dei dati personali per le finalità ivi indicate e di essere consapevole che, in mancanza di rilascio del consenso a tale trattamento,   potranno trovare applicazione le disposizioni indicate nella predetta Informativa.</span>
          </div>
        </fieldset>

        <div className="content__gdpr__leggi">
          <span>Leggi la nostra </span><a href="https://www.iubenda.com/privacy-policy/18177949/legal">informativa sulla privacy</a><span> per informazioni su come gestiamo i tuoi dati e quali sono i tuoi diritti.</span>
        </div>
      </div>
    </div>
  );
};

export default GdprMailchimpSection;
