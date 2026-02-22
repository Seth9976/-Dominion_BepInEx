using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C2 RID: 194
	public class TrackedReference : Object
	{
		// Token: 0x06001117 RID: 4375 RVA: 0x0000A577 File Offset: 0x00008777
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedReference()
		{
			Il2CppClassPointerStore<TrackedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrackedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr);
			TrackedReference.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, "m_Ptr");
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0000A5B0 File Offset: 0x000087B0
		public TrackedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00045A68 File Offset: 0x00043C68
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0000A5B9 File Offset: 0x000087B9
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00045A90 File Offset: 0x00043C90
		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			bool flag = y == null && x == null;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = y == null;
				if (flag3)
				{
					flag2 = x.m_Ptr == IntPtr.Zero;
				}
				else
				{
					bool flag4 = x == null;
					if (flag4)
					{
						flag2 = y.m_Ptr == IntPtr.Zero;
					}
					else
					{
						flag2 = x.m_Ptr == y.m_Ptr;
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00045B04 File Offset: 0x00043D04
		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return !(x == y);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00045B20 File Offset: 0x00043D20
		public override bool Equals(Object o)
		{
			return o.TryCast<TrackedReference>() == this;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00045B40 File Offset: 0x00043D40
		public override int GetHashCode()
		{
			return (int)this.m_Ptr;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00045B60 File Offset: 0x00043D60
		public static implicit operator bool(TrackedReference exists)
		{
			return exists != null;
		}

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;
	}
}
