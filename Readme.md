# Polaris Server



**Polaris Server** is an API that allows the usage of the **PolarisCore** cognition capabilities via HTTP requests.



**How to use it:**

- To process an Input Query: *[domain]/Cognize/[input query here]*

  - The output will be a JSON with three fields.

    - Example: 

      *[domain]/Cognize/***Search about cute kittens please***

      ```json
      {"Code":2,"Response":"Alright! Searching 'cute kittens' for you.","ResponseData":"cute kittens"}
      ```

**How to set it up:**

1. Provide a PolarisCore Binary under */Polaris Server/PolarisCoreBinary/*

   Latest binaries: https://github.com/MeiFagundes/Polaris-Core/releases

2. The naming is not relevant, but make sure it's the only .exe file in the directory.

3. Deploy via Visual Studio.

4. Done! :)


**Powered by:**

![](Design/PoweredBy.png)
