import { KnowledgeBasePage } from './app.po';

describe('knowledge-base App', () => {
  let page: KnowledgeBasePage;

  beforeEach(() => {
    page = new KnowledgeBasePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
