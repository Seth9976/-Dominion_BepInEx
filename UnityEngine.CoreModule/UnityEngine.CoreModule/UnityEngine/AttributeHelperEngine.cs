using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	public class AttributeHelperEngine : Object
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x00041374 File Offset: 0x0003F574
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeHelperEngine()
		{
			Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AttributeHelperEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr);
			AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_disallowMultipleComponentArray");
			AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_executeInEditModeArray");
			AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_requireComponentArray");
			AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664314);
			AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664315);
			AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664316);
			AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664317);
			AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664318);
			AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100664319);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00041458 File Offset: 0x0003F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68204, XrefRangeEnd = 68217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004149C File Offset: 0x0003F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68217, XrefRangeEnd = 68261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetRequiredComponents(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000414E0 File Offset: 0x0003F6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68272, RefRangeEnd = 68273, XrefRangeStart = 68261, XrefRangeEnd = 68272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetExecuteMode(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00041524 File Offset: 0x0003F724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68273, XrefRangeEnd = 68284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CheckIsEditorScript(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00041568 File Offset: 0x0003F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68284, XrefRangeEnd = 68290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDefaultExecutionOrderFor(Type klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000415AC File Offset: 0x0003F7AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68297, RefRangeEnd = 68298, XrefRangeStart = 68290, XrefRangeEnd = 68297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00009CF5 File Offset: 0x00007EF5
		public AttributeHelperEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000415EC File Offset: 0x0003F7EC
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00009CFE File Offset: 0x00007EFE
		public unsafe static Il2CppReferenceArray<DisallowMultipleComponent> _disallowMultipleComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DisallowMultipleComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00041614 File Offset: 0x0003F814
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00009D10 File Offset: 0x00007F10
		public unsafe static Il2CppReferenceArray<ExecuteInEditMode> _executeInEditModeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExecuteInEditMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0004163C File Offset: 0x0003F83C
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00009D22 File Offset: 0x00007F22
		public unsafe static Il2CppReferenceArray<RequireComponent> _requireComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RequireComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr__disallowMultipleComponentArray;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr__executeInEditModeArray;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr__requireComponentArray;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0;

		// Token: 0x0200076D RID: 1901
		private sealed class MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>
		{
			// Token: 0x04001C80 RID: 7296
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0, Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
