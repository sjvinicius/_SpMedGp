import styled from 'styled-components';
import backgrouimg from '../../assets/img/img/bGLogin.png';

export const Container = styled.div`
    background-image: url(${backgrouimg});
    background-color: #C79AFF;
    width: 100vw;
    height: 100vh;
`;

export const Wrapper = styled.div`
    background-color: #FFF;
    width: 400px;
    height: 100vh;
    margin: auto;
    display: flex;
    flex-direction: column;
    border: 1px #8C30FC ;
    border-style: hidden solid;
    
`;

export const Logo = styled.img`
    /* background-color: green; */
    width: 300px;
    height: auto;
    margin: 20px auto;   
`;

export const Tittle = styled.h1`
    margin: 0 auto;
    color: #2B2D42;
    font-size: 26;
    text-transform: uppercase;
`;
 
export const Form = styled.form`
    height: 300px;
    /* background-color: green; */
`;
 
export const InputLog = styled.input`
    width: 300px;
    height: 50px;
    border: 1px solid #8C30FC;
    outline: 0;
    font-size: 22px;
    box-shadow: 0;
    margin-top: 20px;
    margin-left: 45px;
    padding-left: 15px;
    border-radius: 20px;
`;

export const ErroMsg = styled.p`
    color: red;
    font-size: 16px;
    text-align: center;
`;
 
export const ButtonLog = styled.input`
    width: 250px;
    height: 50px;
    border: 1px solid #FFF;
    font-size: 18px;
    margin-top: 20px;
    margin-left: 80px;
    border-radius: 20px;
    text-transform: uppercase;
    background-color: #8C30FC;
    color: #FFF;
    cursor: pointer;

`;
 