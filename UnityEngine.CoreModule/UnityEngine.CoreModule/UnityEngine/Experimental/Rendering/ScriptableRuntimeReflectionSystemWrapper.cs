using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200016C RID: 364
	public class ScriptableRuntimeReflectionSystemWrapper : Object
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x0006025C File Offset: 0x0005E45C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemWrapper()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, "<implementation>k__BackingField");
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100665283);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100665284);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100665285);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100665286);
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x000602F0 File Offset: 0x0005E4F0
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x00060330 File Offset: 0x0005E530
		public unsafe IScriptableRuntimeReflectionSystem implementation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00060374 File Offset: 0x0005E574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83179, XrefRangeEnd = 83180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x000603B4 File Offset: 0x0005E5B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRuntimeReflectionSystemWrapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000EDAA File Offset: 0x0000CFAA
		public ScriptableRuntimeReflectionSystemWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x000603F0 File Offset: 0x0005E5F0
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000EDB3 File Offset: 0x0000CFB3
		public unsafe IScriptableRuntimeReflectionSystem _implementation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr__implementation_k__BackingField;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
