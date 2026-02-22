using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000121 RID: 289
	[StructLayout(2)]
	public struct EarlyUpdate
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x0000CF56 File Offset: 0x0000B156
		// Note: this type is marked as 'beforefieldinit'.
		static EarlyUpdate()
		{
			Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "EarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0000CF7B File Offset: 0x0000B17B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008E3 RID: 2275
		[StructLayout(2)]
		public struct PollPlayerConnection
		{
			// Token: 0x06002FC7 RID: 12231 RVA: 0x00015EB9 File Offset: 0x000140B9
			// Note: this type is marked as 'beforefieldinit'.
			static PollPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06002FC8 RID: 12232 RVA: 0x00015ED9 File Offset: 0x000140D9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E4 RID: 2276
		[StructLayout(2)]
		public struct ProfilerStartFrame
		{
			// Token: 0x06002FC9 RID: 12233 RVA: 0x00015EEB File Offset: 0x000140EB
			// Note: this type is marked as 'beforefieldinit'.
			static ProfilerStartFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProfilerStartFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr);
			}

			// Token: 0x06002FCA RID: 12234 RVA: 0x00015F0B File Offset: 0x0001410B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E5 RID: 2277
		[StructLayout(2)]
		public struct PollHtcsPlayerConnection
		{
			// Token: 0x06002FCB RID: 12235 RVA: 0x00015F1D File Offset: 0x0001411D
			// Note: this type is marked as 'beforefieldinit'.
			static PollHtcsPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollHtcsPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06002FCC RID: 12236 RVA: 0x00015F3D File Offset: 0x0001413D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E6 RID: 2278
		[StructLayout(2)]
		public struct GpuTimestamp
		{
			// Token: 0x06002FCD RID: 12237 RVA: 0x00015F4F File Offset: 0x0001414F
			// Note: this type is marked as 'beforefieldinit'.
			static GpuTimestamp()
			{
				Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "GpuTimestamp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr);
			}

			// Token: 0x06002FCE RID: 12238 RVA: 0x00015F6F File Offset: 0x0001416F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E7 RID: 2279
		[StructLayout(2)]
		public struct AnalyticsCoreStatsUpdate
		{
			// Token: 0x06002FCF RID: 12239 RVA: 0x00015F81 File Offset: 0x00014181
			// Note: this type is marked as 'beforefieldinit'.
			static AnalyticsCoreStatsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "AnalyticsCoreStatsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr);
			}

			// Token: 0x06002FD0 RID: 12240 RVA: 0x00015FA1 File Offset: 0x000141A1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E8 RID: 2280
		[StructLayout(2)]
		public struct UnityWebRequestUpdate
		{
			// Token: 0x06002FD1 RID: 12241 RVA: 0x00015FB3 File Offset: 0x000141B3
			// Note: this type is marked as 'beforefieldinit'.
			static UnityWebRequestUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UnityWebRequestUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr);
			}

			// Token: 0x06002FD2 RID: 12242 RVA: 0x00015FD3 File Offset: 0x000141D3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E9 RID: 2281
		[StructLayout(2)]
		public struct UpdateStreamingManager
		{
			// Token: 0x06002FD3 RID: 12243 RVA: 0x00015FE5 File Offset: 0x000141E5
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06002FD4 RID: 12244 RVA: 0x00016005 File Offset: 0x00014205
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008EA RID: 2282
		[StructLayout(2)]
		public struct ExecuteMainThreadJobs
		{
			// Token: 0x06002FD5 RID: 12245 RVA: 0x00016017 File Offset: 0x00014217
			// Note: this type is marked as 'beforefieldinit'.
			static ExecuteMainThreadJobs()
			{
				Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ExecuteMainThreadJobs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr);
			}

			// Token: 0x06002FD6 RID: 12246 RVA: 0x00016037 File Offset: 0x00014237
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008EB RID: 2283
		[StructLayout(2)]
		public struct ProcessMouseInWindow
		{
			// Token: 0x06002FD7 RID: 12247 RVA: 0x00016049 File Offset: 0x00014249
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMouseInWindow()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessMouseInWindow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr);
			}

			// Token: 0x06002FD8 RID: 12248 RVA: 0x00016069 File Offset: 0x00014269
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008EC RID: 2284
		[StructLayout(2)]
		public struct ClearIntermediateRenderers
		{
			// Token: 0x06002FD9 RID: 12249 RVA: 0x0001607B File Offset: 0x0001427B
			// Note: this type is marked as 'beforefieldinit'.
			static ClearIntermediateRenderers()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearIntermediateRenderers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr);
			}

			// Token: 0x06002FDA RID: 12250 RVA: 0x0001609B File Offset: 0x0001429B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008ED RID: 2285
		[StructLayout(2)]
		public struct ClearLines
		{
			// Token: 0x06002FDB RID: 12251 RVA: 0x000160AD File Offset: 0x000142AD
			// Note: this type is marked as 'beforefieldinit'.
			static ClearLines()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearLines");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr);
			}

			// Token: 0x06002FDC RID: 12252 RVA: 0x000160CD File Offset: 0x000142CD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008EE RID: 2286
		[StructLayout(2)]
		public struct PresentBeforeUpdate
		{
			// Token: 0x06002FDD RID: 12253 RVA: 0x000160DF File Offset: 0x000142DF
			// Note: this type is marked as 'beforefieldinit'.
			static PresentBeforeUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PresentBeforeUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr);
			}

			// Token: 0x06002FDE RID: 12254 RVA: 0x000160FF File Offset: 0x000142FF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008EF RID: 2287
		[StructLayout(2)]
		public struct ResetFrameStatsAfterPresent
		{
			// Token: 0x06002FDF RID: 12255 RVA: 0x00016111 File Offset: 0x00014311
			// Note: this type is marked as 'beforefieldinit'.
			static ResetFrameStatsAfterPresent()
			{
				Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ResetFrameStatsAfterPresent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr);
			}

			// Token: 0x06002FE0 RID: 12256 RVA: 0x00016131 File Offset: 0x00014331
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F0 RID: 2288
		[StructLayout(2)]
		public struct UpdateAsyncReadbackManager
		{
			// Token: 0x06002FE1 RID: 12257 RVA: 0x00016143 File Offset: 0x00014343
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncReadbackManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncReadbackManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr);
			}

			// Token: 0x06002FE2 RID: 12258 RVA: 0x00016163 File Offset: 0x00014363
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F1 RID: 2289
		[StructLayout(2)]
		public struct UpdateTextureStreamingManager
		{
			// Token: 0x06002FE3 RID: 12259 RVA: 0x00016175 File Offset: 0x00014375
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateTextureStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateTextureStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06002FE4 RID: 12260 RVA: 0x00016195 File Offset: 0x00014395
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F2 RID: 2290
		[StructLayout(2)]
		public struct UpdatePreloading
		{
			// Token: 0x06002FE5 RID: 12261 RVA: 0x000161A7 File Offset: 0x000143A7
			// Note: this type is marked as 'beforefieldinit'.
			static UpdatePreloading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdatePreloading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr);
			}

			// Token: 0x06002FE6 RID: 12262 RVA: 0x000161C7 File Offset: 0x000143C7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F3 RID: 2291
		[StructLayout(2)]
		public struct RendererNotifyInvisible
		{
			// Token: 0x06002FE7 RID: 12263 RVA: 0x000161D9 File Offset: 0x000143D9
			// Note: this type is marked as 'beforefieldinit'.
			static RendererNotifyInvisible()
			{
				Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "RendererNotifyInvisible");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr);
			}

			// Token: 0x06002FE8 RID: 12264 RVA: 0x000161F9 File Offset: 0x000143F9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F4 RID: 2292
		[StructLayout(2)]
		public struct PlayerCleanupCachedData
		{
			// Token: 0x06002FE9 RID: 12265 RVA: 0x0001620B File Offset: 0x0001440B
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerCleanupCachedData()
			{
				Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PlayerCleanupCachedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr);
			}

			// Token: 0x06002FEA RID: 12266 RVA: 0x0001622B File Offset: 0x0001442B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F5 RID: 2293
		[StructLayout(2)]
		public struct UpdateMainGameViewRect
		{
			// Token: 0x06002FEB RID: 12267 RVA: 0x0001623D File Offset: 0x0001443D
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMainGameViewRect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateMainGameViewRect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr);
			}

			// Token: 0x06002FEC RID: 12268 RVA: 0x0001625D File Offset: 0x0001445D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F6 RID: 2294
		[StructLayout(2)]
		public struct UpdateCanvasRectTransform
		{
			// Token: 0x06002FED RID: 12269 RVA: 0x0001626F File Offset: 0x0001446F
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateCanvasRectTransform()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateCanvasRectTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr);
			}

			// Token: 0x06002FEE RID: 12270 RVA: 0x0001628F File Offset: 0x0001448F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F7 RID: 2295
		[StructLayout(2)]
		public struct UpdateInputManager
		{
			// Token: 0x06002FEF RID: 12271 RVA: 0x000162A1 File Offset: 0x000144A1
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateInputManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateInputManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr);
			}

			// Token: 0x06002FF0 RID: 12272 RVA: 0x000162C1 File Offset: 0x000144C1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F8 RID: 2296
		[StructLayout(2)]
		public struct ProcessRemoteInput
		{
			// Token: 0x06002FF1 RID: 12273 RVA: 0x000162D3 File Offset: 0x000144D3
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessRemoteInput()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessRemoteInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr);
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x000162F3 File Offset: 0x000144F3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008F9 RID: 2297
		[StructLayout(2)]
		public struct XRUpdate
		{
			// Token: 0x06002FF3 RID: 12275 RVA: 0x00016305 File Offset: 0x00014505
			// Note: this type is marked as 'beforefieldinit'.
			static XRUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "XRUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr);
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x00016325 File Offset: 0x00014525
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FA RID: 2298
		[StructLayout(2)]
		public struct ScriptRunDelayedStartupFrame
		{
			// Token: 0x06002FF5 RID: 12277 RVA: 0x00016337 File Offset: 0x00014537
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedStartupFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ScriptRunDelayedStartupFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr);
			}

			// Token: 0x06002FF6 RID: 12278 RVA: 0x00016357 File Offset: 0x00014557
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FB RID: 2299
		[StructLayout(2)]
		public struct UpdateKinect
		{
			// Token: 0x06002FF7 RID: 12279 RVA: 0x00016369 File Offset: 0x00014569
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateKinect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateKinect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr);
			}

			// Token: 0x06002FF8 RID: 12280 RVA: 0x00016389 File Offset: 0x00014589
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FC RID: 2300
		[StructLayout(2)]
		public struct DeliverIosPlatformEvents
		{
			// Token: 0x06002FF9 RID: 12281 RVA: 0x0001639B File Offset: 0x0001459B
			// Note: this type is marked as 'beforefieldinit'.
			static DeliverIosPlatformEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DeliverIosPlatformEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr);
			}

			// Token: 0x06002FFA RID: 12282 RVA: 0x000163BB File Offset: 0x000145BB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FD RID: 2301
		[StructLayout(2)]
		public struct DispatchEventQueueEvents
		{
			// Token: 0x06002FFB RID: 12283 RVA: 0x000163CD File Offset: 0x000145CD
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchEventQueueEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DispatchEventQueueEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr);
			}

			// Token: 0x06002FFC RID: 12284 RVA: 0x000163ED File Offset: 0x000145ED
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FE RID: 2302
		[StructLayout(2)]
		public struct PhysicsResetInterpolatedTransformPosition
		{
			// Token: 0x06002FFD RID: 12285 RVA: 0x000163FF File Offset: 0x000145FF
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsResetInterpolatedTransformPosition()
			{
				Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PhysicsResetInterpolatedTransformPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
			}

			// Token: 0x06002FFE RID: 12286 RVA: 0x0001641F File Offset: 0x0001461F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FF RID: 2303
		[StructLayout(2)]
		public struct SpriteAtlasManagerUpdate
		{
			// Token: 0x06002FFF RID: 12287 RVA: 0x00016431 File Offset: 0x00014631
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteAtlasManagerUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "SpriteAtlasManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003000 RID: 12288 RVA: 0x00016451 File Offset: 0x00014651
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000900 RID: 2304
		[StructLayout(2)]
		public struct TangoUpdate
		{
			// Token: 0x06003001 RID: 12289 RVA: 0x00016463 File Offset: 0x00014663
			// Note: this type is marked as 'beforefieldinit'.
			static TangoUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TangoUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr);
			}

			// Token: 0x06003002 RID: 12290 RVA: 0x00016483 File Offset: 0x00014683
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000901 RID: 2305
		[StructLayout(2)]
		public struct ARCoreUpdate
		{
			// Token: 0x06003003 RID: 12291 RVA: 0x00016495 File Offset: 0x00014695
			// Note: this type is marked as 'beforefieldinit'.
			static ARCoreUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ARCoreUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr);
			}

			// Token: 0x06003004 RID: 12292 RVA: 0x000164B5 File Offset: 0x000146B5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000902 RID: 2306
		[StructLayout(2)]
		public struct PerformanceAnalyticsUpdate
		{
			// Token: 0x06003005 RID: 12293 RVA: 0x000164C7 File Offset: 0x000146C7
			// Note: this type is marked as 'beforefieldinit'.
			static PerformanceAnalyticsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PerformanceAnalyticsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003006 RID: 12294 RVA: 0x000164E7 File Offset: 0x000146E7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
