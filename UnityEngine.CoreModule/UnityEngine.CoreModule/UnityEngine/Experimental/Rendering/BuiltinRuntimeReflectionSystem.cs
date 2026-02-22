using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000169 RID: 361
	public class BuiltinRuntimeReflectionSystem : Object
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x0005FEAC File Offset: 0x0005E0AC
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "BuiltinRuntimeReflectionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665272);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665273);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665274);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665275);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665276);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100665277);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0005FF54 File Offset: 0x0005E154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83147, XrefRangeEnd = 83149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0005FF90 File Offset: 0x0005E190
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0005FFC4 File Offset: 0x0005E1C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00060004 File Offset: 0x0005E204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BuiltinUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00060034 File Offset: 0x0005E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83149, XrefRangeEnd = 83153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuiltinRuntimeReflectionSystem>(intPtr3) : null;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00060068 File Offset: 0x0005E268
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinRuntimeReflectionSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0000ED41 File Offset: 0x0000CF41
		public BuiltinRuntimeReflectionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
