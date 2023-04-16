# LibSugar.Unity.Mathematics

[![NPM](https://img.shields.io/npm/v/com.libsugar.sugar.unity.mathematics)](https://www.npmjs.com/package/com.libsugar.sugar.unity.mathematics)
[![openupm](https://img.shields.io/npm/v/com.libsugar.sugar.unity.mathematics?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.libsugar.sugar.unity.mathematics/)
![MIT](https://img.shields.io/github/license/libsugar/SugarUnity.Mathematics)

类似语法糖，但是是库

## 安装

- Unity Package 由 [npmjs](https://www.npmjs.com/package/com.libsugar.sugar.unity.mathematics)

  如下编辑你的 `Packages/manifest.json` 文件

  ```json
  {
    "scopedRegistries": [
      {
        "name": "npm",
        "url": "https://registry.npmjs.org",
        "scopes": [
          "com.libsugar"
        ]
      }
    ],
    "dependencies": {
      "com.libsugar.sugar.unity.mathematics": "<version>"
    }
  }
  ```
  或者在 unity 编辑器中操作  
  配置 `Project Settings -> Package Manager -> Scoped Registeries`  
  然后在包管理器中添加包  
