import React, { useEffect } from 'react';

const Iubenda = () => {
  useEffect(() => {
    const loader = () => {
      const script = document.createElement('script');
      script.src = 'https://cdn.iubenda.com/iubenda.js';
      script.async = true;
      document.body.appendChild(script);
    };

    if (window.addEventListener) {
      window.addEventListener('load', loader, false);
    } else if (window.attachEvent) {
      window.attachEvent('onload', loader);
    } else {
      window.onload = loader;
    }

    return () => {
      if (window.removeEventListener) {
        window.removeEventListener('load', loader, false);
      } else if (window.detachEvent) {
        window.detachEvent('onload', loader);
      }
    };
  }, []);

  return (
    <span>
      <a
        href="https://www.iubenda.com/privacy-policy/18177949"
        className="iubenda-black iubenda-noiframe iubenda-embed iubenda-noiframe"
        title="Informativa sulla privacy"
      >
        informativa sulla privacy
      </a>
    </span>
  );
};

export default Iubenda;
