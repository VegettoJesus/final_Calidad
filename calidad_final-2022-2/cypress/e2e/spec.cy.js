describe('Examen Final', () => {
  it('Generar Cartas', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#generar').click()
    cy.location('pathname').should('eq','/home/generar')
  })
  it('Guardar Cartas', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#guardar').click()
    cy.location('pathname').should('eq','/Home/guardar')
    cy.get('#guard').click()
    cy.location('pathname').should('eq','/Home/guardar')
  })
  it('Ingresar Privacy', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
  it('Ingresar Privacy por footer', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#priv').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
  it('Ingresar botones layout', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
    cy.get('#guardar').click()
    cy.location('pathname').should('eq','/Home/guardar')
    cy.get('#index').click()
  })
})