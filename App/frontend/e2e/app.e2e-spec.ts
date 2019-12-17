import { InvoiceAppTemplatePage } from './app.po';

describe('InvoiceApp App', function() {
  let page: InvoiceAppTemplatePage;

  beforeEach(() => {
    page = new InvoiceAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
