using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	public sealed class CallContext : Object
	{
		// Token: 0x06003EE0 RID: 16096 RVA: 0x00125150 File Offset: 0x00123350
		// Note: this type is marked as 'beforefieldinit'.
		static CallContext()
		{
			Il2CppClassPointerStore<CallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContext>.NativeClassPtr);
			CallContext.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672511);
			CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672512);
			CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672513);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x001251BC File Offset: 0x001233BC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001251F8 File Offset: 0x001233F8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SetCurrentCallContext(LogicalCallContext ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0012523C File Offset: 0x0012343C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354024, RefRangeEnd = 354026, XrefRangeStart = 354021, XrefRangeEnd = 354024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00017C19 File Offset: 0x00015E19
		public CallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0;
	}
}
