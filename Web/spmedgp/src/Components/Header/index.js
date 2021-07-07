import React from 'react'
import { useHistory } from 'react-router-dom';

import logo from '../../assets/img/img/LogoHeader.png'

import { Container, HeaderC, NavMenu, LogoNav, NavItem, Action, TextFt, TextUs, Logout } from './styles'

export default function Header() {

    const history = useHistory();

    function NavToConsultas(params) {
        history.push('/Consultas')
    }

    function NavToNovaConsulta(params) {
        history.push('/NovaConsulta')
    }

    return(
        <>
            <Container>
                <HeaderC>
                    <NavMenu>
                            <LogoNav src={logo}/>
                            <NavItem > Sobre </NavItem>
                            <NavItem onClick={NavToConsultas} > Minhas Consultas </NavItem>
                            <NavItem onClick={NavToNovaConsulta} > Nova Consulta </NavItem>
                    </NavMenu>
                    <Action>
                        <TextFt> Olá </TextFt>
                        <TextUs> @User </TextUs>
                        <Logout href='' > Sair </Logout>
                    </Action>
                </HeaderC>
            </Container>
        </>

    )
    
}