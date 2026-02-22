using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x020000AF RID: 175
	public class SetupCoroutine : Object
	{
		// Token: 0x06001047 RID: 4167 RVA: 0x00042AE0 File Offset: 0x00040CE0
		// Note: this type is marked as 'beforefieldinit'.
		static SetupCoroutine()
		{
			Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SetupCoroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100664361);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100664362);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00042B38 File Offset: 0x00040D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69900, XrefRangeEnd = 69906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00042B7C File Offset: 0x00040D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69906, XrefRangeEnd = 69911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeMember(Object behaviour, string name, Object variable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0000A1A1 File Offset: 0x000083A1
		public SetupCoroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0000A1AA File Offset: 0x000083AA
		public static Object InvokeStatic(Type klass, string name, Object variable)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0;
	}
}
