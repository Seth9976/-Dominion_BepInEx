using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst.LowLevel
{
	// Token: 0x020001A3 RID: 419
	public static class BurstCompilerService
	{
		// Token: 0x06001C15 RID: 7189 RVA: 0x00061D88 File Offset: 0x0005FF88
		public static string GetDisassembly(MethodInfo m, string compilerOptions)
		{
			IntPtr intPtr = BurstCompilerService.GetDisassemblyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(m), IL2CPP.ManagedStringToIl2Cpp(compilerOptions));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0000F67E File Offset: 0x0000D87E
		public static int CompileAsyncDelegateMethod(Object delegateMethod, string compilerOptions)
		{
			return BurstCompilerService.CompileAsyncDelegateMethodDelegateField(IL2CPP.Il2CppObjectBaseToPtr(delegateMethod), IL2CPP.ManagedStringToIl2Cpp(compilerOptions));
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0000F696 File Offset: 0x0000D896
		public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
		{
			return BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegateField(userID);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00061DB4 File Offset: 0x0005FFB4
		public static string GetMethodSignature(MethodInfo method)
		{
			IntPtr intPtr = BurstCompilerService.GetMethodSignatureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0000F6A3 File Offset: 0x0000D8A3
		public static bool IsInitialized
		{
			get
			{
				return BurstCompilerService.get_IsInitializedDelegateField();
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0000F6AF File Offset: 0x0000D8AF
		public static void SetCurrentExecutionMode(uint environment)
		{
			BurstCompilerService.SetCurrentExecutionModeDelegateField(environment);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		public static uint GetCurrentExecutionMode()
		{
			return BurstCompilerService.GetCurrentExecutionModeDelegateField();
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		public unsafe static void Log(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			BurstCompilerService.LogDelegateField(userData, logType, message, filename, lineNumber);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0000F6DA File Offset: 0x0000D8DA
		public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
		{
			return BurstCompilerService.LoadBurstLibraryDelegateField(IL2CPP.ManagedStringToIl2Cpp(fullPathToLibBurstGenerated));
		}

		// Token: 0x040015DD RID: 5597
		private static readonly BurstCompilerService.GetDisassemblyDelegate GetDisassemblyDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetDisassemblyDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly");

		// Token: 0x040015DE RID: 5598
		private static readonly BurstCompilerService.CompileAsyncDelegateMethodDelegate CompileAsyncDelegateMethodDelegateField = IL2CPP.ResolveICall<BurstCompilerService.CompileAsyncDelegateMethodDelegate>("Unity.Burst.LowLevel.BurstCompilerService::CompileAsyncDelegateMethod");

		// Token: 0x040015DF RID: 5599
		private static readonly BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegate GetAsyncCompiledAsyncDelegateMethodDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetAsyncCompiledAsyncDelegateMethod");

		// Token: 0x040015E0 RID: 5600
		private static readonly BurstCompilerService.GetMethodSignatureDelegate GetMethodSignatureDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetMethodSignatureDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature");

		// Token: 0x040015E1 RID: 5601
		private static readonly BurstCompilerService.get_IsInitializedDelegate get_IsInitializedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");

		// Token: 0x040015E2 RID: 5602
		private static readonly BurstCompilerService.SetCurrentExecutionModeDelegate SetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.SetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode");

		// Token: 0x040015E3 RID: 5603
		private static readonly BurstCompilerService.GetCurrentExecutionModeDelegate GetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode");

		// Token: 0x040015E4 RID: 5604
		private static readonly BurstCompilerService.LogDelegate LogDelegateField = IL2CPP.ResolveICall<BurstCompilerService.LogDelegate>("Unity.Burst.LowLevel.BurstCompilerService::Log");

		// Token: 0x040015E5 RID: 5605
		private static readonly BurstCompilerService.LoadBurstLibraryDelegate LoadBurstLibraryDelegateField = IL2CPP.ResolveICall<BurstCompilerService.LoadBurstLibraryDelegate>("Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary");

		// Token: 0x02000A90 RID: 2704
		public enum BurstLogType
		{
			// Token: 0x04001D91 RID: 7569
			Info,
			// Token: 0x04001D92 RID: 7570
			Warning,
			// Token: 0x04001D93 RID: 7571
			Error
		}

		// Token: 0x02000A91 RID: 2705
		// (Invoke) Token: 0x06003324 RID: 13092
		private delegate IntPtr GetDisassemblyDelegate(IntPtr m, IntPtr compilerOptions);

		// Token: 0x02000A92 RID: 2706
		// (Invoke) Token: 0x06003326 RID: 13094
		private delegate int CompileAsyncDelegateMethodDelegate(IntPtr delegateMethod, IntPtr compilerOptions);

		// Token: 0x02000A93 RID: 2707
		// (Invoke) Token: 0x06003328 RID: 13096
		private delegate IntPtr GetAsyncCompiledAsyncDelegateMethodDelegate(int userID);

		// Token: 0x02000A94 RID: 2708
		// (Invoke) Token: 0x0600332A RID: 13098
		private delegate IntPtr GetMethodSignatureDelegate(IntPtr method);

		// Token: 0x02000A95 RID: 2709
		// (Invoke) Token: 0x0600332C RID: 13100
		private delegate bool get_IsInitializedDelegate();

		// Token: 0x02000A96 RID: 2710
		// (Invoke) Token: 0x0600332E RID: 13102
		private delegate void SetCurrentExecutionModeDelegate(uint environment);

		// Token: 0x02000A97 RID: 2711
		// (Invoke) Token: 0x06003330 RID: 13104
		private delegate uint GetCurrentExecutionModeDelegate();

		// Token: 0x02000A98 RID: 2712
		// (Invoke) Token: 0x06003332 RID: 13106
		private delegate void LogDelegate(IntPtr userData, BurstCompilerService.BurstLogType logType, IntPtr message, IntPtr filename, int lineNumber);

		// Token: 0x02000A99 RID: 2713
		// (Invoke) Token: 0x06003334 RID: 13108
		private delegate bool LoadBurstLibraryDelegate(IntPtr fullPathToLibBurstGenerated);
	}
}
