using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000BC RID: 188
	public class ScriptableObject : Object
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x0004528C File Offset: 0x0004348C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObject()
		{
			Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
			ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664453);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664454);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664455);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664456);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664457);
			ScriptableObject.SetDirtyDelegateField = IL2CPP.ResolveICall<ScriptableObject.SetDirtyDelegate>("UnityEngine.ScriptableObject::SetDirty");
			ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField = IL2CPP.ResolveICall<ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate>("UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName");
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField = IL2CPP.ResolveICall<ScriptableObject.ResetAndApplyDefaultInstancesDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances");
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 72365, RefRangeEnd = 72387, XrefRangeStart = 72359, XrefRangeEnd = 72365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0004538C File Offset: 0x0004358C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72389, RefRangeEnd = 72390, XrefRangeStart = 72387, XrefRangeEnd = 72389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000453D0 File Offset: 0x000435D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 72396, RefRangeEnd = 72402, XrefRangeStart = 72390, XrefRangeEnd = 72396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>() where T : ScriptableObject
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00045400 File Offset: 0x00043600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72402, XrefRangeEnd = 72404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateScriptableObject(ScriptableObject self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00045438 File Offset: 0x00043638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72404, XrefRangeEnd = 72406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyDefaultsAndReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0000A481 File Offset: 0x00008681
		public ScriptableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0000A48A File Offset: 0x0000868A
		public void SetDirty()
		{
			ScriptableObject.SetDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0004548C File Offset: 0x0004368C
		public static ScriptableObject CreateInstance(string className)
		{
			return ScriptableObject.CreateScriptableObjectInstanceFromName(className);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000454A4 File Offset: 0x000436A4
		public static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
		{
			IntPtr intPtr = ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(className));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0000A49C File Offset: 0x0000869C
		public static void ResetAndApplyDefaultInstances(Object obj)
		{
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly ScriptableObject.SetDirtyDelegate SetDirtyDelegateField;

		// Token: 0x04000CCE RID: 3278
		private static readonly ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate CreateScriptableObjectInstanceFromNameDelegateField;

		// Token: 0x04000CCF RID: 3279
		private static readonly ScriptableObject.ResetAndApplyDefaultInstancesDelegate ResetAndApplyDefaultInstancesDelegateField;

		// Token: 0x020007A3 RID: 1955
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x04001C9D RID: 7325
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007A4 RID: 1956
		// (Invoke) Token: 0x06002CE8 RID: 11496
		private delegate void SetDirtyDelegate(IntPtr @this);

		// Token: 0x020007A5 RID: 1957
		// (Invoke) Token: 0x06002CEA RID: 11498
		private delegate IntPtr CreateScriptableObjectInstanceFromNameDelegate(IntPtr className);

		// Token: 0x020007A6 RID: 1958
		// (Invoke) Token: 0x06002CEC RID: 11500
		private delegate void ResetAndApplyDefaultInstancesDelegate(IntPtr obj);
	}
}
