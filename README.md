# Code_lab_10.1

Unity 作业项目。仓库一级目录就是 Unity 项目根目录。

## 打开项目

1. 下载或克隆整个仓库。
2. 在 Unity Hub 中选择添加本地项目，选择仓库文件夹 `Code_lab_10.1`（直接包含 `Assets`、`Packages` 和 `ProjectSettings` 的目录）。
3. 使用 **Unity 6000.0.84f1** 打开项目，等待依赖和资源导入完成。
4. 打开 `Assets/Scenes/SampleScene.unity` 场景。

## 提交内容

- `Assets/`：场景、脚本、资源及其 `.meta` 文件。
- `Packages/`：依赖清单和锁定文件。
- `ProjectSettings/`：项目配置和 Unity 版本。
- `.gitignore`、本说明及许可证。

项目中的 `.gitignore` 会排除 `Library/`、`Temp/`、`Logs/`、`UserSettings/`、构建产物和本地编辑器配置。这些文件保留在本机，不上传到 Git。Unity 会在打开项目时重新生成所需缓存。

提交作业时，在 GitHub Desktop 中选择本仓库，检查 Changes，填写提交说明后 Commit，再 Push；如果仓库尚未发布，使用 Publish repository。

## 项目配置记录

根据 2026-10-01 的本地项目文件检查：

- Unity 版本：6000.0.84f1（`ProjectSettings/ProjectVersion.txt`）。
- 渲染：Universal Render Pipeline 17.0.4（依赖清单和 Graphics Settings）。
- 输入：Input System 1.20.0，项目启用新输入系统。
- 构建场景：`Assets/Scenes/SampleScene.unity`。
- 当前脚本主要为模板说明及编辑器初始化脚本，尚未发现自定义游戏架构或测试程序集。
- 已配置 Unity Test Framework 1.6.0；本次仅核对 Git 提交范围，未运行 Unity、测试或构建。
- 依赖清单中未发现 Unity MCP 包；编辑器连接状态未验证。

以上路径均相对于仓库根目录；此记录基于尚未提交的本地文件。
