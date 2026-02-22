using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000437 RID: 1079
	public sealed class Ephemeron : ValueType
	{
		// Token: 0x06004265 RID: 16997 RVA: 0x00131904 File Offset: 0x0012FB04
		// Note: this type is marked as 'beforefieldinit'.
		static Ephemeron()
		{
			Il2CppClassPointerStore<Ephemeron>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "Ephemeron");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr);
			Ephemeron.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "key");
			Ephemeron.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "value");
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00019622 File Offset: 0x00017822
		public Ephemeron(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0001962B File Offset: 0x0001782B
		public Ephemeron()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr))
		{
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x0013195C File Offset: 0x0012FB5C
		// (set) Token: 0x06004269 RID: 17001 RVA: 0x0001963D File Offset: 0x0001783D
		public unsafe Object key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x0013198C File Offset: 0x0012FB8C
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x0001965C File Offset: 0x0001785C
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeFieldInfoPtr_value;
	}
}
