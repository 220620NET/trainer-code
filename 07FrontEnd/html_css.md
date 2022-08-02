# HTML & CSS
[MDN Guide on Web Development](https://developer.mozilla.org/en-US/docs/Learn)

## HTML
- Hypertext Markup Language
- NOT(!) a programming language
- Determines the structure of the web page
- current standard: HTML 5

### Moving parts of HTML
- Elements
    - The basic component of html
- Attributes
    - Additional values that configure elements or adjust their behaviors (akin to flags in terminal commands) 
    - Global
        - attributes that can be used on any elements
        - id, class
        - style
        - all event handlers (onclick, etc)

### Anatomy of a web page
- html
- head
- body

### Web Accessibility
- [MDN Doc](https://developer.mozilla.org/en-US/docs/Learn/Accessibility)
- [W3C Intro on Accessibility](https://www.w3.org/WAI/fundamentals/accessibility-intro/)
- [10 Tips on Making your website more accessible](https://webaccess.berkeley.edu/resources/tips/web-accessibility)
- [Foundations Course](https://www.w3.org/WAI/fundamentals/foundations-course/)

#### Weirdly common qc q: Head, Heading, Header?

## CSS
- Cascading Style Sheet
- Also NOT(!) a programming language
- Determines the look of the web page
- current standard: CSS 3

### Including CSS in your HTML
- Inline: Style attribute
- Internal: Style Tag
- *External*: a separate CSS file through Link tag

### Selectors
*If you remember 1 thing about CSS, remember this*

Selector is a way to target stylings to one or more elements
- Tag selector
- Id Selector
- Class Selector
- [Combinator](https://developer.mozilla.org/en-US/docs/Learn/CSS/Building_blocks/Selectors/Combinators)
    - Descendant
    - Child
    - Adjacent sibling 
    - General Sibling 
- Pseudo-class
- Pseudo-element

### Rules
Key-value pair for styles

### Applying Styles: Cascading, Inheritance
#### Cascading in CSS
#### Specificity
#### Inheriting Style

### Box Model (very common qc question)
- Margin
- Border
- Padding
- Content

### Responsive Web Design
This is a design principle that no matter the screen size, the webpages should re-organize themselves to provide good ux(user experience)
#### (Bootstrap)[https://getbootstrap.com/]