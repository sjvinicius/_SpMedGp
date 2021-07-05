import styled from 'styled-components';

export const Container = styled.div`
  width: 100%;
  height: 20;
  color: #2B2D42;
`;

export const HeaderC = styled.div`
  background-color: #FFF;
  width: 1200px;
  margin: auto;
  display: flex;
  align-items: center;
  border-radius: 30px;
  border: 1px #8C30FC solid;
  
`;

export const NavMenu = styled.div`
  display:flex;
  align-items: center;
`;

export const LogoNav = styled.img``;

export const NavItem = styled.a`
  &:hover {
    color:#8C30FC;

  };
  color: #2B2D42;
  margin-right: 30px;
  font-weight: bold;
  text-decoration: none;
`;

export const Action = styled.div`
  width: 600px;
  display: flex;
  align-items: center;
  justify-content: flex-end;
`;

export const TextFt = styled.p`
  color: #C79AFF;
  font-weight: bold;
  margin-right: 10px;
`;

export const TextUs = styled.p`
  margin-right: 10px;
  text-transform: uppercase;
  font-weight: bold;
`;

export const Logout = styled.a`
  color: red;
  font-size: 12px;
  text-decoration: none;

`;



