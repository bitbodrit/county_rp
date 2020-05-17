import { createGlobalStyle } from 'styled-components';


const GlobalStyle = createGlobalStyle`
  * {
    margin:  0;
    padding: 0;

    font-family: 'Roboto', sans-serif;
  }

  @keyframes slide-up {
    0% {
      opacity: 0;
      transform: translateY(20px);
    }
    100% {
      opacity: 1;
      transform: translateY(0);
    }
  }

  @keyframes fade-in { 
    0% { 
      opacity: 0; 
    } 
    100% { 
      opacity: 1; 
    } 
  }

`;


export default GlobalStyle;