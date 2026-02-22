using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003C RID: 60
	public class ScriptingUnityCallback : Object
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingUnityCallback()
		{
			Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ScriptingUnityCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr);
			ScriptingUnityCallback.NativeFieldInfoPtr_forwardTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr, "forwardTo");
			ScriptingUnityCallback.NativeFieldInfoPtr_util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr, "util");
			ScriptingUnityCallback.NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr, 100663538);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000C35C File Offset: 0x0000A55C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingUnityCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forwardTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingUnityCallback.NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002EFE File Offset: 0x000010FE
		public ScriptingUnityCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002F07 File Offset: 0x00001107
		public unsafe IUnityCallback forwardTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingUnityCallback.NativeFieldInfoPtr_forwardTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnityCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingUnityCallback.NativeFieldInfoPtr_forwardTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002F26 File Offset: 0x00001126
		public unsafe IUtil util
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingUnityCallback.NativeFieldInfoPtr_util);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingUnityCallback.NativeFieldInfoPtr_util), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_forwardTo;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_util;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_IUtil_0;
	}
}
