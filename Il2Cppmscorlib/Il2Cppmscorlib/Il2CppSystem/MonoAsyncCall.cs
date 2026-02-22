using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000120 RID: 288
	public class MonoAsyncCall : Object
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x0007FECC File Offset: 0x0007E0CC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAsyncCall()
		{
			Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoAsyncCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr);
			MonoAsyncCall.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "msg");
			MonoAsyncCall.NativeFieldInfoPtr_cb_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_method");
			MonoAsyncCall.NativeFieldInfoPtr_cb_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_target");
			MonoAsyncCall.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "state");
			MonoAsyncCall.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "res");
			MonoAsyncCall.NativeFieldInfoPtr_out_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "out_args");
			MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, 100666812);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0007FF88 File Offset: 0x0007E188
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoAsyncCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000072A1 File Offset: 0x000054A1
		public MonoAsyncCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0007FFC4 File Offset: 0x0007E1C4
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x000072AA File Offset: 0x000054AA
		public unsafe Object msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x000072C9 File Offset: 0x000054C9
		public unsafe IntPtr cb_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0008001C File Offset: 0x0007E21C
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x000072E4 File Offset: 0x000054E4
		public unsafe Object cb_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0008004C File Offset: 0x0007E24C
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00007303 File Offset: 0x00005503
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0008007C File Offset: 0x0007E27C
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00007322 File Offset: 0x00005522
		public unsafe Object res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x000800AC File Offset: 0x0007E2AC
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x00007341 File Offset: 0x00005541
		public unsafe Object out_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeFieldInfoPtr_cb_method;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeFieldInfoPtr_cb_target;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeFieldInfoPtr_out_args;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
