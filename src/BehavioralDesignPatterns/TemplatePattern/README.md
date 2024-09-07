# Recruiting Application

## Overview

This project is a **Recruiting Application** that allows users to upload CV files in various formats, such as **PDF**, **Image**, and **.doc**. The application is designed to generate a report based on these CVs, helping recruiters filter out non-relevant candidates. 

To generate the report, the system requires several steps such as **reading the files**, **extracting data**, **analyzing the data**, and **generating the final report**. These steps share common functionality, but each CV format might have slight variations in how the process is performed.

To implement this functionality in a flexible and reusable way, we employ the **Template Method Design Pattern**.

---

## Template Method Design Pattern

The **Template Method Pattern** is a behavioral design pattern that defines the skeleton of an algorithm in a base class but allows subclasses to override specific steps of the algorithm without changing its structure. In this system, the Template Method Pattern is used to handle the process of generating reports from different CV formats while maintaining the overall workflow in a base class.

### How it works:

- **Abstract Class (Template)**: Defines the steps required for generating a report. Some steps have default implementations, while others are left abstract to be implemented by subclasses.
- **Concrete Classes**: Each concrete class corresponds to a specific CV format (e.g., PDF, Image, .doc) and implements the specific behavior of certain steps in the report generation process (such as reading and extracting data).
- **Invariant Process**: The steps of reading files, extracting data, analyzing data, and generating reports are performed in the same sequence for all CV formats, ensuring consistency.

By using the Template Method Pattern, the system allows for reuse of the common workflow while enabling different formats to be handled in a customized manner.

---

## Example Usage of Template Method Pattern

The Template Method Pattern enables us to encapsulate the report generation logic while allowing customization for different file formats. For example:

1. **Common Steps**: These might include reading the file, analyzing extracted data, and generating the report.
2. **Custom Steps**: These steps differ depending on the file format, such as reading a PDF, extracting text from an image, or parsing a .doc file.

### Benefits:

- **Reusability**: The common workflow for report generation is reused across all formats.
- **Customization**: Each CV format can provide its specific implementation of certain steps without modifying the overall process.

---

## Conclusion

By using the **Template Method Design Pattern**, we efficiently manage different CV formats while maintaining a consistent report generation process. This pattern allows for easy extension and modification when adding support for new file formats, ensuring the system is both **flexible** and **scalable** for future enhancements.

