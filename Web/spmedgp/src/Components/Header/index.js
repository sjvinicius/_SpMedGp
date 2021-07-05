import React from 'react'

import logo from '../../assets/img/img/LogoHeader.png'

import { Container, HeaderC, NavMenu, LogoNav, NavItem, Action, TextFt, TextUs, Logout } from './styles'

export default function Header() {
    return(
        <>
            <Container>
                <HeaderC>
                    <NavMenu>
                            <LogoNav src={logo}/>
                            <NavItem href='' > Sobre </NavItem>
                            <NavItem href='' > Minhas Consultas </NavItem>
                            <NavItem href='' > Nova Consulta </NavItem>
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