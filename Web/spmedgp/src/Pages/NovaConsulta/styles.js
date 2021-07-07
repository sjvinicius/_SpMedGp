import styled from 'styled-components';
import bGNovaConsulta from '../../assets/img/img/bGConsultas.png'


export const Container = styled.div`
    background-image: ${bGNovaConsulta};
    background-color: #C79AFF;
    
`;
export const Window = styled.div`
    background-color: #FFf;
    width: 700px;
    height: 500px;
    margin: auto;
    border-radius: 20px;
`;

export const Tittle = styled.div`
    background-color: #FFF;
    width: 400px;
    color: #CC2424;
    font-weight: bold;
    font-size: 18px;
    border: 1px #8C30FC solid;
    border-radius: 15px;
    margin: 20px auto;
    text-align: center;
`;

export const ContentForm = styled.div`
    /* background-color: green; */
    margin: auto;
    width: 600px;

`;

export const Form = styled.form`
    display:flex;
    flex-direction: column;
    align-items: center;

  
`;

export const TittleInput = styled.h3`
    font-size: 16px;
    color: #2B2D42;

`;

export const Input = styled.input`
    width: 180px;
    height: 35px;   
    border-radius: 20px;
    border: 1px #8C30FC solid;
    padding-left: 15px;
    
`;
export const Select = styled.select`
    width: 180px;
    height: 35px;   
    border-radius: 20px;
    border: 1px #8C30FC solid;
    padding-left: 15px;
`;
export const Date = styled.input`
    width: 180px;
    height: 35px;   
    border-radius: 20px;
    border: 1px #8C30FC solid;
    padding-left: 15px;
`;
export const FooterButtons = styled.div`    
    /* background-color: black; */
    width: 400px;
    height: 60px;
    display: flex;
    align-items: center;
    justify-content: space-around;
    /* margin-bottom: 20px; */
    margin-top: 40px;
`;
export const Cancel = styled.a`
  font-size: 22px;
  color: #2B2D42;
  font-weight: bold;
  text-decoration: underline;
  cursor: pointer;
`;
export const Schedule = styled.input`
  background-color: #E5322E;
  width: 120px;
  height: 35px;
  border: 1px solid black;
  border-radius: 15px;
  color: #FFF;
  font-size: 22px;
  cursor: pointer;
  text-align: center;
`;
