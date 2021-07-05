import styled from 'styled-components';


export const Container = styled.div`
    width: 100%;
    height: auto;
    border-top: 2px solid #FFF;
    display:flex;
    justify-content:center;
`;

export const ContentHeader = styled.div`
    /* background-color: green; */
    display: flex;
    justify-content: space-around;
    align-items: center;
    border-bottom: 1px solid #FFF;
    margin-bottom: 10px;

`;

export const ContentItem = styled.div`
    /* background-color: red; */
    width: 50;
    height: 40;
`;

export const TextHeader = styled.p`
    font-size: 12px;
    color: #FFF;
`;

export const Logo = styled.img`
    /* background-color:red; */
    width: 150;
    height: 80;
`;
