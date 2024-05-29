import React, { useEffect } from "react";
import $ from "jquery";
import styled from "styled-components";

const QrContainer = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  padding: 1rem;

  @media (min-width: 768px) {
    padding: 0; // Rimuovi padding su schermi più grandi
  }
`;

const QrImage = styled.img`
  max-width: 100%;
  max-height: 100%;

  @media (min-width: 768px) {
    max-width: 50vw; // Limita la dimensione dell'immagine su schermi più grandi
    max-height: 50vh;
  }
`;

const Qr = () => {
  useEffect(() => {
    //mount
    $("header, footer, #CookiebotWidget").hide();
    return () => {
      //unmount
      $("header, footer, #CookiebotWidget").show();
    };
  }, []);

  return (
    <QrContainer>
      <QrImage
        src={process.env.PUBLIC_URL + '/img/qr-code.png'}
        alt="QR Code - NetxData"
      />
    </QrContainer>
  );
};

export default Qr;
